CREATE DATABASE Kauetrack ;
USE Kauetrack;

SELECT * FROM colaborador;
SELECT * FROM departamento;
SELECT * FROM funcao;
SELECT * FROM servico;
SELECT * FROM viagem;
SELECT * FROM viagem_colaborador;

UPDATE colaborador SET cpf = "32145678910" WHERE id = 198;
UPDATE colaborador SET nome = "Juliana Barros" WHERE id = 199;
UPDATE colaborador SET departamento_id = "90" WHERE id = 200;

SELECT * FROM colaborador WHERE nome = "Juliana Ramos";

DELETE FROM colaborador WHERE id = 127;