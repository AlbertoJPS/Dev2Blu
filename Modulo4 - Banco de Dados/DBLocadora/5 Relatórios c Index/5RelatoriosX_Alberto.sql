
-- 5 Relatórios com Index - Alberto Santos

-- ==========================================================================================================================================
-- 1 = Busca de Veículos por Localização ====================================================================================================

EXPLAIN SELECT
F.Nome AS 'Filial',
Ma.Nome AS 'Marca',
Mo.Nome AS 'Modelo',
Cr.Placa,
Cr.StatusCarro
FROM Carro Cr
JOIN Filial F ON Cr.Filial_Id = F.Id
JOIN Modelo Mo ON Cr.Modelo_Id = Mo.Id
JOIN Marca Ma ON Mo.Marca_Id = Ma.Id
WHERE F.Nome = 'Blumenau' AND Cr.AtivoCarro = 'True';

-- ==========================================================================

CREATE INDEX IDX_Filial_Nome ON Filial(Nome);
CREATE INDEX IDX_FK_Carro_Filial ON Carro(Filial_Id);

DROP INDEX IDX_Filial_Nome ON Filial;
DROP INDEX IDX_FK_Carro_Filial ON Carro;

-- ==========================================================================================================================================
-- 2 = Busca de Histórico de Cliente ========================================================================================================

EXPLAIN SELECT
P.Nome,
R.DataReserva,
R.DataRetirada,
R.ValorTotal
FROM Reserva R
JOIN Pessoa P ON R.Pessoa_Id = P.Id
WHERE P.CPF = '99988877766' AND R.StatusReserva = 'Finalizado'
ORDER BY R.DataReserva DESC;

-- ==========================================================================

CREATE INDEX IDX_Pessoa_CPF ON Pessoa(CPF);
CREATE INDEX IDX_Reserva_Pessoa_Status_Data ON Reserva(Pessoa_Id, StatusReserva, DataReserva);

DROP INDEX IDX_Pessoa_CPF ON Pessoa;
DROP INDEX IDX_Reserva_Pessoa_Status_Data ON Reserva;

-- ==========================================================================================================================================
-- 3 = Relatório de Reservas em um Período ==================================================================================================

EXPLAIN SELECT
Id,
Pessoa_Id,
Carro_Id,
DataRetirada,
StatusReserva
FROM Reserva
WHERE StatusReserva = 'Aberto' AND DataRetirada BETWEEN '2024-02-01' AND '2024-08-07';

-- ==========================================================================

CREATE INDEX IDX_Reserva_Status_DataRetirada ON Reserva(StatusReserva, DataRetirada);

DROP INDEX IDX_Reserva_Status_DataRetirada ON Reserva;

-- ==========================================================================================================================================
-- 4 = Listagem de Frota Ordenada (Foco no ORDER BY) ========================================================================================

EXPLAIN SELECT
Ma.Nome AS 'Marca',
Mo.Nome AS 'Modelo',
Cr.AnoFabricacao,
Cr.Valor
FROM Carro Cr
JOIN Modelo Mo ON Cr.Modelo_Id = Mo.Id
JOIN Marca Ma ON Mo.Marca_Id = Ma.Id
ORDER BY Ma.Nome, Mo.Nome;

-- ==========================================================================

CREATE INDEX IDX_Marca_Nome ON Marca(Nome);
CREATE INDEX IDX_Modelo_Nome ON Modelo(Nome);
CREATE INDEX IDX_FK_Carro_Modelo ON Carro(Modelo_Id);
CREATE INDEX IDX_FK_Modelo_Marca ON Modelo(Marca_Id);

DROP INDEX IDX_Marca_Nome ON Marca;
DROP INDEX IDX_Modelo_Nome ON Modelo;

ALTER TABLE Carro DROP FOREIGN KEY FK_Carro_Modelo;
DROP INDEX IDX_FK_Carro_Modelo ON Carro;
ALTER TABLE Modelo DROP FOREIGN KEY FK_Modelo_Marca;
DROP INDEX IDX_FK_Modelo_Marca ON Modelo;

-- ==========================================================================================================================================
-- 5 = Busca por Veículo Específico =========================================================================================================

EXPLAIN SELECT
Id,
Placa,
AnoFabricacao,
KmTotal,
StatusCarro,
Filial_Id
FROM Carro
WHERE Placa = 'AKL8K90';

-- ==========================================================================

CREATE INDEX IDX_Carro_Placa ON Carro(Placa);

DROP INDEX IDX_Carro_Placa ON Carro;

-- ==========================================================================================================================================

-- ERROS ao Dropar:

ALTER TABLE Reserva DROP FOREIGN KEY FK_Reserva_Pessoa;
DROP INDEX idx_reserva_pessoa_status_data ON Reserva; 

ALTER TABLE Carro DROP FOREIGN KEY FK_Carro_Filial;
DROP INDEX idx_carro_filial_FK ON Carro; 

-- ==========================================================================
-- ==========================================================================

EXPLAIN SELECT *
FROM Cidade C
JOIN Estado E ON E.Id = C.Estado_Id
WHERE E.Nome = "SC";

CREATE INDEX IDX_Estado_Nome ON Estado(Nome);
CREATE INDEX IDX_FK_Cidade_Estado ON Cidade(Estado_Id);

EXPLAIN SELECT *
FROM Estado E
JOIN Cidade C
ON E.Nome = "SC"
AND E.Id = C.Estado_Id;

-- ==========================================================================
-- ==========================================================================
