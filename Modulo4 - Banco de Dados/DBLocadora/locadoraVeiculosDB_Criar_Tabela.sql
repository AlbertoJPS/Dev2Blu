CREATE DATABASE locadoraVeiculosDB;
USE locadoraVeiculosDB;

CREATE TABLE Estado (
	Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(2)
);

CREATE TABLE Genero (
	Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome ENUM("Masculino", "Feminino", "Outros")
);

CREATE TABLE Categoria (
	Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(225)
);

CREATE TABLE Servico (
	Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(225),
    Descricao TEXT
);

ALTER TABLE Servico ADD COLUMN Valor DECIMAL(16,4);

CREATE TABLE Cidade (
	Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(225),
    Estado_Id INT, 
    CONSTRAINT FK_Cidade_Estado FOREIGN KEY (Estado_Id) REFERENCES Estado(Id)
);

CREATE TABLE Filial (
	Id INT AUTO_INCREMENT PRIMARY KEY,
    Cidade_Id INT, 
    CONSTRAINT FK_Filial_Cidade FOREIGN KEY (Cidade_Id) REFERENCES Cidade(Id),
    Nome VARCHAR(225),
    Endereco VARCHAR(225),
    Telefone VARCHAR(16),
    Email VARCHAR(225),
    Cep VARCHAR(8)
);

CREATE TABLE Marca (
	Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(225)
);

CREATE TABLE Modelo (
	Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(225),
    Categoria_Id INT, 
    CONSTRAINT FK_Modelo_Categoria FOREIGN KEY (Categoria_Id) REFERENCES Categoria(Id),
    Marca_Id INT, 
    CONSTRAINT FK_Modelo_Marca FOREIGN KEY (Marca_Id) REFERENCES Marca(Id)
);

CREATE TABLE Carro (
	Id INT AUTO_INCREMENT PRIMARY KEY,
    Filial_Id INT, 
    CONSTRAINT FK_Carro_Filial FOREIGN KEY (Filial_Id) REFERENCES Filial(Id),
    Modelo_Id INT, 
    CONSTRAINT FK_Carro_Modelo FOREIGN KEY (Modelo_Id) REFERENCES Modelo(Id),
    Placa VARCHAR(9),
    AnoFabricacao INT(4),
    CapacidadeMala INT(4),
    CapacidadePessoa INT(1),
    Motor VARCHAR(16),
    TipoCambio ENUM("Manual","Automatico"),
    Valor DECIMAL(16,4),
    Situacao ENUM("Disponivel","Indisponivel","Em Manutencao"),
    KmTotal INT(16)
);

CREATE TABLE Pessoa (
	Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(225),
    Genero_Id INT, 
    CONSTRAINT FK_Pessoa_Genero FOREIGN KEY (Genero_Id) REFERENCES Genero(Id),
    CPF VARCHAR(11),
    CNH VARCHAR(11),
    Endereco VARCHAR(225),
    Cidade_Id INT, 
    CONSTRAINT FK_Pessoa_Cidade FOREIGN KEY (Cidade_Id) REFERENCES Cidade(Id),
    Cep VARCHAR(8),
    Telefone VARCHAR(16),
    Email VARCHAR(225),
    Senha VARCHAR(225),
    Ativo ENUM("Sim","Nao")
);

CREATE TABLE PacoteDesconto (
	Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(225),
    Descricao TEXT,
    Valor DECIMAL(16,4)
);

CREATE TABLE PacoteDesconto_Servico (
	PacoteDesconto_Id INT, 
    FOREIGN KEY (PacoteDesconto_Id) REFERENCES PacoteDesconto(Id),
    Servico_Id INT, 
    FOREIGN KEY (Servico_Id) REFERENCES Servico(Id),
    PRIMARY KEY(PacoteDesconto_Id, Servico_Id)
);

CREATE TABLE Reserva (
	Id INT AUTO_INCREMENT PRIMARY KEY,
    Pessoa_Id INT, 
    CONSTRAINT FK_Reserva_Pessoa FOREIGN KEY (Pessoa_Id) REFERENCES Pessoa(Id),
	PacoteDesconto_Id INT, 
    CONSTRAINT FK_Reserva_PacoteDesconto FOREIGN KEY (PacoteDesconto_Id) REFERENCES PacoteDesconto(Id),
    Carro_Id INT, 
    CONSTRAINT FK_Reserva_Carro FOREIGN KEY (Carro_Id) REFERENCES Carro(Id),
    DataRetirada DATETIME,
    DataDevolucao DATETIME,
    ValorTotal DECIMAL(16,4),
    StatusReserva ENUM("Aberto", "Pendente", "Finalizado"),
    DataReserva DATETIME
);

CREATE TABLE Reserva_Servico (
	Reserva_Id INT, 
    FOREIGN KEY (Reserva_Id) REFERENCES Reserva(Id),
    Servico_Id INT, 
    FOREIGN KEY (Servico_Id) REFERENCES Servico(Id),
    PRIMARY KEY(Reserva_Id, Servico_Id)
);

---------------------------------------------------------------

CREATE TABLE Teste (
	Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(225)
);

ALTER TABLE Teste ADD COLUMN Altura VARCHAR(50);

ALTER TABLE Teste MODIFY COLUMN Altura INT;

ALTER TABLE Teste DROP COLUMN Altura;

CREATE TABLE Teste2 (
	Id INT AUTO_INCREMENT PRIMARY KEY
);

ALTER TABLE Teste ADD COLUMN Test2_Id INT;

ALTER TABLE Teste ADD CONSTRAINT FK_Teste_Teste2 FOREIGN KEY (Test2_Id) REFERENCES Teste2(Id);

ALTER TABLE Teste DROP FOREIGN KEY FK_Teste_Teste2;

DROP TABLE Teste2;

ALTER TABLE Teste DROP COLUMN Test2_Id;

/*
Estrutura

create
alter
drop

Tabelas

add
modify
drop

Dados

create
read
update
delete
*/

---------------------------------------------------------------

ALTER TABLE Pessoa ADD COLUMN Motorista VARCHAR(225);

ALTER TABLE Pessoa CHANGE COLUMN CNH MotoristaCNH INT(11);

ALTER TABLE Carro CHANGE COLUMN Situacao StatusCarro ENUM("Disponivel","Indisponivel","Em Manutencao");

CREATE TABLE Pendencia (
	Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(225),
    Descricao TEXT,
    Custo DECIMAL(16,4)
);

ALTER TABLE Carro ADD COLUMN Pendencia_Id INT;

ALTER TABLE Carro ADD CONSTRAINT FK_Carro_Pendencia FOREIGN KEY (Pendencia_Id) REFERENCES Pendencia(Id);


-----------------------------------------------------

INSERT INTO Categoria (Id, Nome) VALUES (2, "SUV");

INSERT INTO Categoria (Nome) VALUES (2, "Sedan"), (3, "Hatch"), (4, "Picape"), (5, "Cupê");

INSERT INTO Categoria (Nome) VALUES ("Conversível"), ("Perua"), ("Minivan"), ("Crossover");

SELECT * FROM Filial;

ALTER TABLE Carro MODIFY COLUMN Motor VARCHAR(45);
