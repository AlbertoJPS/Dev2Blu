/*
CRUD - LOCADORAVEICULOSDB - Alberto Santos

=====================================================================
1. CREATE
=====================================================================
*/

-- Tabela Genero
INSERT INTO Genero (Id, Nome) VALUES 
(4, 'Outros+');

-- Tabela Estado
INSERT INTO Estado (Id, Nome) VALUES 
(28, 'EX');

-- Tabela Categoria
INSERT INTO Categoria (Id, Nome) VALUES 
(10, 'Voador');

-- Tabela Servico
INSERT INTO Servico (Id, Nome, Descricao, Valor) VALUES 
(8, 'Assento Pet', 'Capa de proteção e cinto de segurança para animais de estimação.', 45.00);

-- Tabela Pendencia
INSERT INTO Pendencia (Id, Nome, Descricao, Custo) VALUES 
(8, 'Pneu Estepe Furado', 'Substituição ou reparo de pneu avariado não coberto pelo seguro.', 150.00);

-- Tabela Marca
INSERT INTO Marca (Id, Nome) VALUES 
(101, 'Levian');

-- Tabela PacoteDesconto
INSERT INTO PacoteDesconto (Id, Nome, Descricao, Valor) VALUES 
(5, 'Pacote Feriado', 'Desconto especial para feriados prolongados.', 90.00);

-- Tabela Cidade
INSERT INTO Cidade (Id, Nome, Estado_Id) VALUES 
(5569, 'Nova Blumenau', 24);

-- Tabela Modelo
INSERT INTO Modelo (Id, Nome, Categoria_Id, Marca_Id) VALUES 
(201, 'Happy Bird', 10, 101);

-- Tabela Filial
INSERT INTO Filial (Id, Cidade_Id, Nome, Endereco, Telefone, Email, Cep) VALUES 
(201, 5569, 'New Gen - Nova Vila Nova', 'Rua Theodoro Holtrup, 501', '(47) 99888-7766', 'filial.novavilanova@dbrent.com', '89035999');

-- Tabela Pessoa
INSERT INTO Pessoa (Id, Nome, Genero_Id, CPF, MotoristaCNH, Motorista, Endereco, Cidade_Id, Cep, Telefone, Email, Senha, Ativo) VALUES 
(401, 'Ellon Musk', 4, '12345678999', '01234567890', 'Ellon Musk', 'Rua Teste, 123', 898, '89010000', '(47) 99999-9998', 'novo.cliente@email.com', '$2a$10$fK/0K/0K/0K/0K/0K/0K.Z99', 'Sim');

-- Tabela Carro
INSERT INTO Carro (Id, Filial_Id, Modelo_Id, Pendencia_Id, Placa, AnoFabricacao, CapacidadeMala, CapacidadePessoa, Motor, TipoCambio, Valor, StatusCarro, KmTotal) VALUES 
(701, 201, 201, 8, 'VOA9Z99', 2030, 50, 2, '6.0', 'Automatico', 1300.00, 'Disponivel', 10);

-- Tabela Reserva
INSERT INTO Reserva (Id, Pessoa_Id, PacoteDesconto_Id, Carro_Id, DataRetirada, DataDevolucao, ValorTotal, StatusReserva, DataReserva) VALUES 
(201, 401, 1, 701, '2025-10-01 12:00:00', '2025-10-05 12:00:00', 5200.00, 'Aberto', '2025-09-16 21:30:00');

-- Tabela PacoteDesconto_Servico
INSERT INTO PacoteDesconto_Servico (PacoteDesconto_Id, Servico_Id) VALUES 
(5, 1);

-- Tabela Reserva_Servico
INSERT INTO Reserva_Servico (Reserva_Id, Servico_Id) VALUES 
(201, 1);

/*
=====================================================================
2. READ
=====================================================================
*/

SELECT * FROM Genero;
SELECT * FROM Estado;
SELECT * FROM Categoria;
SELECT * FROM Servico;
SELECT * FROM Pendencia;
SELECT * FROM Marca;
SELECT * FROM PacoteDesconto;
SELECT * FROM Cidade;
SELECT * FROM Modelo;
SELECT * FROM Filial;
SELECT * FROM Pessoa;
SELECT * FROM Carro;
SELECT * FROM Reserva;
SELECT * FROM PacoteDesconto_Servico;
SELECT * FROM Reserva_Servico;

/*
=====================================================================
3. UPDATE
=====================================================================
*/

-- Tabela Genero
UPDATE Genero SET Nome = 'PersonalizadÍssimo' WHERE Id = 4;

-- Tabela Estado
UPDATE Estado SET Nome = 'NA' WHERE Id = 28;

-- Tabela Categoria
UPDATE Categoria SET Nome = 'Veículo Aéreo' WHERE Id = 10;

-- Tabela Servico
UPDATE Servico SET 
    Nome = 'Assento Pet Premium', 
    Descricao = 'Assento de luxo e climatizado para animais de estimação.', 
    Valor = 65.00 
WHERE Id = 8;

-- Tabela Pendencia
UPDATE Pendencia SET 
    Nome = 'Pneu Estepe Ausente', 
    Descricao = 'Carro devolvido sem o pneu estepe.', 
    Custo = 550.00 
WHERE Id = 8;

-- Tabela Marca
UPDATE Marca SET Nome = 'Levian Motors' WHERE Id = 101;

-- Tabela PacoteDesconto
UPDATE PacoteDesconto SET 
    Nome = 'Pacote Feriado Especial', 
    Descricao = 'Desconto e serviços exclusivos para feriados nacionais.', 
    Valor = 99.00 
WHERE Id = 5;

-- Tabela Cidade
UPDATE Cidade SET 
    Nome = 'Nova Blumenau do Sul', 
    Estado_Id = 24 
WHERE Id = 5569;

-- Tabela Modelo
UPDATE Modelo SET 
    Nome = 'Happy Bird 2.0', 
    Categoria_Id = 10, 
    Marca_Id = 101 
WHERE Id = 201;

-- Tabela Filial
UPDATE Filial SET 
    Cidade_Id = 5569, 
    Nome = 'AeroVila', 
    Endereco = 'Rua das Turbinas, 01', 
    Telefone = '(47) 97777-7777', 
    Email = 'aerovila.bnu@dbrent.com', 
    Cep = '89035900' 
WHERE Id = 201;

-- Tabela Pessoa
UPDATE Pessoa SET 
    Nome = 'Elon Musk', 
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
    Ativo = 'Sim' 
WHERE Id = 401;

-- Tabela Carro
UPDATE Carro SET 
    Filial_Id = 201, 
    Modelo_Id = 201, 
    Pendencia_Id = 8, 
    Placa = 'MARTE01', 
    AnoFabricacao = 2031, 
    CapacidadeMala = 40, 
    CapacidadePessoa = 1, 
    Motor = 'Foguete (Elétrico)', 
    TipoCambio = 'Automatico', 
    Valor = 9950.00, 
    StatusCarro = 'Em Manutencao', 
    KmTotal = 50 
WHERE Id = 701;

-- Tabela Reserva
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

-- Tabela PacoteDesconto_Servico
UPDATE PacoteDesconto_Servico SET 
    Servico_Id = 8 
WHERE PacoteDesconto_Id = 5 AND Servico_Id = 1;

-- Tabela Reserva_Servico
UPDATE Reserva_Servico SET 
    Servico_Id = 8 
WHERE Reserva_Id = 201 AND Servico_Id = 1;

/*
=====================================================================
4. DELETE
=====================================================================
*/

-- 1. Deletando de tabelas associativas "Primeiro" (após update)
DELETE FROM Reserva_Servico WHERE Reserva_Id = 201 AND Servico_Id = 8; 
DELETE FROM PacoteDesconto_Servico WHERE PacoteDesconto_Id = 5 AND Servico_Id = 8; 

-- 2. Deletando de tabelas principais (Filhas/Pais)
DELETE FROM Reserva WHERE Id = 201;
DELETE FROM Carro WHERE Id = 701;
DELETE FROM Pessoa WHERE Id = 401;
DELETE FROM Modelo WHERE Id = 201;
DELETE FROM Filial WHERE Id = 201;
DELETE FROM Cidade WHERE Id = 5569;

-- 3. Deletando de tabelas de lookup (Pais)
DELETE FROM PacoteDesconto WHERE Id = 5;
DELETE FROM Marca WHERE Id = 101;
DELETE FROM Pendencia WHERE Id = 8;
DELETE FROM Servico WHERE Id = 8;
DELETE FROM Categoria WHERE Id = 10;
DELETE FROM Genero WHERE Id = 4;
DELETE FROM Estado WHERE Id = 28;