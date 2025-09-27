/*
CRUD - LOCADORAVEICULOSDB - Alberto Santos
*/

-- =====================================================================
-- MODULO - Gênero
-- =====================================================================

-- #POST - CREATE
INSERT INTO Genero (Id, Nome) VALUES 
(5, 'Outros2+');

-- #GET - SELECT
SELECT * FROM Genero WHERE id = 5;

-- #PUT - UPDATE
UPDATE Genero SET 
    Nome = 'Animal' 
WHERE Id = 5;

-- #DELETE - DELETE (Lógico)
UPDATE Genero SET AtivoGenero = 'False' WHERE Id = 5;
-- =====================================================================

-- =====================================================================
-- MODULO - Estado
-- =====================================================================

-- #POST - CREATE
INSERT INTO Estado (Id, Nome) VALUES 
(29, 'NP');

-- #GET - SELECT
SELECT * FROM Estado WHERE id = 29;

-- #PUT - UPDATE
UPDATE Estado SET 
    Nome = 'US' 
WHERE Id = 29;

-- #DELETE - DELETE (Lógico)
UPDATE Estado SET AtivoEstado = 'False' WHERE Id = 29;
-- =====================================================================

-- =====================================================================
-- MODULO - Cidade
-- =====================================================================

-- #POST - CREATE
INSERT INTO Cidade (Id, Nome, Estado_Id) VALUES 
(5570, 'Blumenau Americana', 29);

-- #GET - SELECT
SELECT * FROM Cidade WHERE id = 5570;

-- #PUT - UPDATE
UPDATE Cidade SET 
    Nome = 'Blumenau Canadense', 
    Estado_Id = 24 
WHERE Id = 5570;

-- #DELETE - DELETE (Lógico)
UPDATE Cidade SET AtivoCidade = 'False' WHERE Id = 5570;
-- =====================================================================

-- =====================================================================
-- MODULO - Categoria
-- =====================================================================

-- #POST - CREATE
INSERT INTO Categoria (Id, Nome) VALUES 
(12, 'Marinho');

-- #GET - SELECT
SELECT * FROM Categoria WHERE id = 12;

-- #PUT - UPDATE
UPDATE Categoria SET 
    Nome = 'Veículo Marinho' 
WHERE Id = 12;

-- #DELETE - DELETE (Lógico)
UPDATE Categoria SET AtivoCategoria = 'False' WHERE Id = 12;
-- =====================================================================

-- =====================================================================
-- MODULO - Marca
-- =====================================================================

-- #POST - CREATE
INSERT INTO Marca (Id, Nome) VALUES 
(102, 'Boiano');

-- #GET - SELECT
SELECT * FROM Marca WHERE id = 102;

-- #PUT - UPDATE
UPDATE Marca SET 
    Nome = 'Boiano Motors' 
WHERE Id = 102;

-- #DELETE - DELETE (Lógico)
UPDATE Marca SET AtivoMarca = 'False' WHERE Id = 102;
-- =====================================================================

-- =====================================================================
-- MODULO - Modelo
-- =====================================================================

-- #POST - CREATE
INSERT INTO Modelo (Id, Nome, Categoria_Id, Marca_Id) VALUES 
(202, 'Jet Car', 12, 102);

-- #GET - SELECT
SELECT * FROM Modelo WHERE id = 202;

-- #PUT - UPDATE
UPDATE Modelo SET 
    Nome = 'Jet Car RTX1080', 
    Categoria_Id = 12, 
    Marca_Id = 102 
WHERE Id = 202;

-- #DELETE - DELETE (Lógico)
UPDATE Modelo SET AtivoModelo = 'False' WHERE Id = 202;
-- =====================================================================

-- =====================================================================
-- MODULO - Pendencias
-- =====================================================================

-- #POST - CREATE
INSERT INTO Pendencia (Id, Nome, Descricao, Custo) VALUES 
(9, 'Afundado', 'Recuperação de veiculo imergido', 700.00);

-- #GET - SELECT
SELECT * FROM Pendencia WHERE id = 9;

-- #PUT - UPDATE
UPDATE Pendencia SET 
    Nome = 'Veiculo Afundado', 
    Descricao = 'Recuperação de veiculo imergido e guincho', 
    Custo = 900.00 
WHERE Id = 9;

-- #DELETE - DELETE (Lógico)
UPDATE Pendencia SET AtivoPendencia = 'False' WHERE Id = 9;
-- =====================================================================

-- =====================================================================
-- MODULO - Filial
-- =====================================================================

-- #POST - CREATE
INSERT INTO Filial (Id, Cidade_Id, Nome, Endereco, Telefone, Email, Cep) VALUES 
(202, 5570, 'New Regen - Nova Vila Nova', 'Rua Theodoro Holzen, 502', '(47) 99888-7756', 'filial.sulvilanova@dbrent.com', '89035899');

-- #GET - SELECT
SELECT * FROM Filial WHERE id = 202;

-- #PUT - UPDATE
UPDATE Filial SET 
    Cidade_Id = 5570, 
    Nome = 'AquaVila', 
    Endereco = 'Rua dasTurbinas, 02', 
    Telefone = '(47) 97777-7778', 
    Email = 'aquavila.bnu@dbrent.com', 
    Cep = '89035900' 
WHERE Id = 202;

-- #DELETE - DELETE (Lógico)
UPDATE Filial SET AtivoFilial = 'False' WHERE Id = 202;
-- =====================================================================

-- =====================================================================
-- MODULO - Carro
-- =====================================================================

-- #POST - CREATE
INSERT INTO Carro (Id, Filial_Id, Modelo_Id, Pendencia_Id, Placa, AnoFabricacao, CapacidadeMala, CapacidadePessoa, Motor, TipoCambio, Valor, StatusCarro, KmTotal) VALUES 
(702, 202, 202, 9, 'BOIAZ99', 2029, 20, 3, '5.0', 'Automatico', 5300.00, 'Em Manutencao', 70);

-- #GET - SELECT
SELECT * FROM Carro WHERE id = 702;

-- #PUT - UPDATE
UPDATE Carro SET 
    Filial_Id = 202, 
    Modelo_Id = 202, 
    Pendencia_Id = 9, 
    Placa = 'PLUTO01', 
    AnoFabricacao = 2030, 
    CapacidadeMala = 10, 
    CapacidadePessoa = 2, 
    Motor = 'Jato (Elétrico)', 
    TipoCambio = 'Automatico', 
    Valor = 7900.00, 
    StatusCarro = 'Disponivel', 
    KmTotal = 1000 
WHERE Id = 702;

-- #DELETE - DELETE (Lógico)
UPDATE Carro SET AtivoCarro = 'False' WHERE Id = 702;
-- =====================================================================

-- =====================================================================
-- MODULO - Pessoa
-- =====================================================================

-- #POST - CREATE
INSERT INTO Pessoa (Id, Nome, Genero_Id, CPF, MotoristaCNH, Motorista, Endereco, Cidade_Id, Cep, Telefone, Email, Senha, AtivoPessoa) VALUES 
(402, 'Elon Musk 2', 4, '12345678999', '01234567890', 'Ellon Muskit', 'Rua Testada, 123', 5570, '89010100', '(47) 99799-9998', 'tio.cliente@email.com', '$2a$10$fK/0K/0K/0K/0K/0K/0K.Z99', 'True');

-- #GET - SELECT
SELECT * FROM Pessoa WHERE id = 402;

-- #PUT - UPDATE
UPDATE Pessoa SET 
    Nome = 'Ellon Musk Filho', 
    Genero_Id = 1, 
    CPF = '99988877766', 
    MotoristaCNH = '09876543555', 
    Motorista = 'A-Xii', 
    Endereco = 'Rua Marte, 1', 
    Cidade_Id = 898, 
    Cep = '89010001', 
    Telefone = '(47) 98888-8888', 
    Email = 'elon@tesla.com', 
    Senha = '$2a$10$NEWPASS/TESLA/SPACEX.A', 
    AtivoPessoa = 'True' 
WHERE Id = 402;

-- #DELETE - DELETE (Lógico)
UPDATE Pessoa SET AtivoPessoa = 'False' WHERE Id = 402;
-- =====================================================================

-- =====================================================================
-- MODULO - Pacote de Desconto
-- =====================================================================

-- #POST - CREATE
INSERT INTO PacoteDesconto (Id, Nome, Descricao, Valor) VALUES 
(6, 'Primeira Viagem', 'Desconto especial para primeiro aluguel', 95.00);

-- #GET - SELECT
SELECT * FROM PacoteDesconto WHERE id = 6;

-- #PUT - UPDATE
UPDATE PacoteDesconto SET 
    Nome = 'Primeira Viagem Especial', 
    Descricao = 'Desconto especial para primeiro aluguel de veiculo', 
    Valor = 100.00 
WHERE Id = 6;

-- #DELETE - DELETE (Lógico)
UPDATE PacoteDesconto SET AtivoPacoteDesconto = 'False' WHERE Id = 6;
-- =====================================================================

-- =====================================================================
-- MODULO - Serviço
-- =====================================================================

-- #POST - CREATE
INSERT INTO Servico (Id, Nome, Descricao, Valor) VALUES 
(9, 'Colete', 'Traje de proteção a vida', 45.00);

-- #GET - SELECT
SELECT * FROM Servico WHERE id = 9;

-- #PUT - UPDATE
UPDATE Servico SET 
    Nome = 'Colete salva-vidas', 
    Descricao = 'Traje de proteção a vida para se manter preparado para qualquer eventualidade', 
    Valor = 30.00 
WHERE Id = 9;

-- #DELETE - DELETE (Lógico)
UPDATE Servico SET AtivoServico = 'False' WHERE Id = 9;
-- =====================================================================

-- =====================================================================
-- MODULO - Reserva
-- =====================================================================

-- #POST - CREATE
INSERT INTO Reserva (Id, Pessoa_Id, PacoteDesconto_Id, Carro_Id, DataRetirada, DataDevolucao, ValorTotal, StatusReserva, DataReserva) VALUES 
(201, 401, 1, 701, '2025-10-01 12:00:00', '2025-10-05 12:00:00', 5200.00, 'Aberto', '2025-09-16 21:30:00');

-- #GET - SELECT
SELECT * FROM 
    Reserva R
    JOIN Pessoa P ON R.Pessoa_Id = P.Id
		JOIN Genero G ON P.Genero_Id = G.Id
		JOIN Cidade CidPessoa ON P.Cidade_Id = CidPessoa.Id
			JOIN Estado EstPessoa ON CidPessoa.Estado_Id = EstPessoa.Id
    JOIN Carro Cr ON R.Carro_Id = Cr.Id
        JOIN Modelo M ON Cr.Modelo_Id = M.Id
            JOIN Marca Ma ON M.Marca_Id = Ma.Id
			JOIN Filial F ON Cr.Filial_Id = F.Id
                JOIN Cidade CidFilial ON F.Cidade_Id = CidFilial.Id
					JOIN Estado EstFilial ON CidFilial.Estado_Id = EstFilial.Id
		LEFT JOIN Pendencia PND ON Cr.Pendencia_Id = PND.Id
    JOIN PacoteDesconto PD ON R.PacoteDesconto_Id = PD.Id
WHERE 
    R.Id = 201;

-- #PUT - UPDATE
UPDATE Reserva SET 
    Pessoa_Id = 401, 
    PacoteDesconto_Id = 5, 
    Carro_Id = 701, 
    DataRetirada = '2026-01-01 12:00:00', 
    DataDevolucao = '2026-01-10 12:00:00', 
    ValorTotal = 89649.00, 
    StatusReserva = 'Pendente', 
    DataReserva = '2025-09-17 10:00:00' 
WHERE Id = 201;

-- #DELETE - DELETE (Lógico)
UPDATE Reserva SET AtivoReserva = 'False' WHERE Id = 201;
-- =====================================================================

-- =====================================================================
-- MODULO - Tabelas Associativas
-- =====================================================================
-- ---------------------------------------------
-- PacoteDesconto_Servico
-- ---------------------------------------------

-- #POST - CREATE
INSERT INTO PacoteDesconto_Servico (PacoteDesconto_Id, Servico_Id) VALUES 
(5, 1);

-- #PUT - UPDATE
UPDATE PacoteDesconto_Servico SET 
    Servico_Id = 8 
WHERE PacoteDesconto_Id = 5 AND Servico_Id = 1;

-- #DELETE - DELETE 
DELETE FROM PacoteDesconto_Servico WHERE PacoteDesconto_Id = 5 AND Servico_Id = 8; 

-- ---------------------------------------------
-- Reserva_Servico
-- ---------------------------------------------

-- #POST - CREATE
INSERT INTO Reserva_Servico (Reserva_Id, Servico_Id) VALUES 
(201, 1);

-- #PUT - UPDATE
UPDATE Reserva_Servico SET 
    Servico_Id = 8 
WHERE Reserva_Id = 201 AND Servico_Id = 1;

-- #DELETE - DELETE 
DELETE FROM Reserva_Servico WHERE Reserva_Id = 201 AND Servico_Id = 8; 
-- =====================================================================