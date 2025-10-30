
-- Atividade Alberto J P Santos

-- -----------------------------------------------------------------------------

-- Parte 1: 5 Consultas com CTEs 

-- -----------------------------------------------------------------------------
-- 1. Relatório de Faturamento por Cliente (CTE Simples)
WITH ReservasFinalizadas AS (
    SELECT 
        Pessoa_Id, 
        ValorTotal
    FROM 
        Reserva
    WHERE 
        StatusReserva = 'Finalizado'
)
SELECT
    P.Nome AS 'Cliente',
    P.CPF AS 'CPF_Cliente',
    COUNT(R.Pessoa_Id) AS 'Total_de_Reservas',
    ROUND(SUM(R.ValorTotal), 2) AS 'Gasto_Total_R$'
FROM 
    Pessoa P
    JOIN ReservasFinalizadas R ON P.Id = R.Pessoa_Id
GROUP BY 
    P.Id
ORDER BY 
    Gasto_Total_R$ DESC;
    
-- -----------------------------------------------------------------------------
-- -----------------------------------------------------------------------------
-- 2. Relatório de Carros Mais Antigos por Filial (CTE com Agregação)

WITH FrotaInfo AS (
    SELECT
        Filial_Id,
        COUNT(Id) AS Total_Carros,
        MIN(AnoFabricacao) AS Ano_Carro_Mais_Antigo
    FROM 
        Carro
    WHERE
        AtivoCarro = 'True'
    GROUP BY
        Filial_Id
)
SELECT 
    F.Nome AS 'Filial',
    C.Nome AS 'Cidade',
    E.Nome AS 'UF',
    FI.Total_Carros,
    FI.Ano_Carro_Mais_Antigo
FROM 
    FrotaInfo FI
    JOIN Filial F ON FI.Filial_Id = F.Id
    JOIN Cidade C ON F.Cidade_Id = C.Id
    JOIN Estado E ON C.Estado_Id = E.Id
ORDER BY
    E.Nome, C.Nome;
    
-- -----------------------------------------------------------------------------
-- -----------------------------------------------------------------------------
-- 3. Relatório de Clientes por Estado (Tabela Derivada)

SELECT
    E.Nome AS 'UF',
    Contagem_Clientes.Total
FROM (
    SELECT 
        C.Estado_Id, 
        COUNT(P.Id) AS Total
    FROM Pessoa P
    JOIN Cidade C ON P.Cidade_Id = C.Id
    GROUP BY C.Estado_Id
) AS Contagem_Clientes
JOIN Estado E ON Contagem_Clientes.Estado_Id = E.Id
ORDER BY 
    E.Nome;

-- -----------------------------------------------------------------------------
-- -----------------------------------------------------------------------------
-- 4. Relatório de Popularidade de Categorias de Veículos

WITH ContagemAlugueis AS (
    SELECT 
        Cr.Modelo_Id,
        COUNT(R.Id) AS Numero_de_Alugueis
    FROM Reserva R
    JOIN Carro Cr ON R.Carro_Id = Cr.Id
    GROUP BY Cr.Modelo_Id
)
SELECT 
    Cat.Nome AS 'Categoria',
    SUM(CA.Numero_de_Alugueis) AS 'Total_Alugueis_na_Categoria'
FROM 
    ContagemAlugueis CA
    JOIN Modelo Mo ON CA.Modelo_Id = Mo.Id
    JOIN Categoria Cat ON Mo.Categoria_Id = Cat.Id
GROUP BY 
    Cat.Nome
ORDER BY 
    Total_Alugueis_na_Categoria DESC;
    
-- -----------------------------------------------------------------------------
-- -----------------------------------------------------------------------------
-- 5. Relatório de Reservas com Pacotes de Desconto

WITH ReservasComPacote AS (
    SELECT *
    FROM Reserva
    WHERE PacoteDesconto_Id != 1 -- ID 1 é o pacote "Nenhum"
)
SELECT
    R.Id AS 'Nº Reserva',
    P.Nome AS 'Cliente',
    Cr.Placa AS 'Placa do Carro',
    PD.Nome AS 'Pacote'
FROM 
    ReservasComPacote R
    JOIN Pessoa P ON R.Pessoa_Id = P.Id
    JOIN Carro Cr ON R.Carro_Id = Cr.Id
    JOIN PacoteDesconto PD ON R.PacoteDesconto_Id = PD.Id
ORDER BY 
    R.Id;
    
-- -----------------------------------------------------------------------------
-- -----------------------------------------------------------------------------
-- -----------------------------------------------------------------------------
-- -----------------------------------------------------------------------------

-- Parte 2: Trigger para Tabela de Log

-- -----------------------------------------------------------------------------
-- Passo 1: Criar a Tabela de Log

CREATE TABLE Log_Pessoa (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Pessoa_Id INT,
    Acao VARCHAR(10),
    Descricao TEXT,
    DataLog DATETIME,
    Usuario_DB VARCHAR(255)
);

-- -----------------------------------------------------------------------------
-- -----------------------------------------------------------------------------
-- Passo 2: Criar as Triggers
-- Passo 2.1: Trigger para INSERT

CREATE TRIGGER TRG_Pessoa_After_Insert
AFTER INSERT ON Pessoa
FOR EACH ROW
BEGIN
    INSERT INTO Log_Pessoa (Pessoa_Id, Acao, Descricao, DataLog, Usuario_DB)
    VALUES (NEW.Id, 'INSERT', CONCAT('Novo cliente cadastrado: ', NEW.Nome, ', CPF: ', NEW.CPF), NOW(), USER());
END;

-- -----------------------------------------------------------------------------
-- -----------------------------------------------------------------------------
-- Passo 2.2: Trigger para UPDATE

CREATE TRIGGER TRG_Pessoa_After_Update
AFTER UPDATE ON Pessoa
FOR EACH ROW
BEGIN
    DECLARE detalhes_alteracao TEXT;
    SET detalhes_alteracao = CONCAT('Alteração no cliente ID ', OLD.Id, ': ');

    IF OLD.Nome != NEW.Nome THEN
        SET detalhes_alteracao = CONCAT(detalhes_alteracao, 'Nome alterado de "', OLD.Nome, '" para "', NEW.Nome, '". ');
    END IF;
    IF OLD.Email != NEW.Email THEN
        SET detalhes_alteracao = CONCAT(detalhes_alteracao, 'Email alterado de "', OLD.Email, '" para "', NEW.Email, '". ');
    END IF;
    IF OLD.AtivoPessoa != NEW.AtivoPessoa THEN
        SET detalhes_alteracao = CONCAT(detalhes_alteracao, 'Status alterado de "', OLD.AtivoPessoa, '" para "', NEW.AtivoPessoa, '". ');
    END IF;
    
    INSERT INTO Log_Pessoa (Pessoa_Id, Acao, Descricao, DataLog, Usuario_DB)
    VALUES (OLD.Id, 'UPDATE', detalhes_alteracao, NOW(), USER());
END;

-- -----------------------------------------------------------------------------
-- -----------------------------------------------------------------------------
-- Passo 2.3: Trigger para DELETE

-- -----------------------------------------------------------------------------
-- -----------------------------------------------------------------------------
--
























