--DDL = Data Definition Language


--Cria o banco de dados
CREATE DATABASE BancoTarde;


--Usa o banco de dados
USE BancoTarde;


--Criar tabela
CREATE TABLE Funcionarios
(
	IdFuncionario INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(10)
);


--Tabela com Chave Estrangeira
CREATE TABLE Empresas
(
	IdEmpresa INT PRIMARY KEY IDENTITY,
	IdFuncionario INT FOREIGN KEY REFERENCES Funcionarios(IdFuncionario),
	Nome VARCHAR(32)
);


--Alterar tabelas
--Adicionar coluna
ALTER TABLE Funcionarios
ADD Cpf VARCHAR(11)

--Remover tabela
ALTER TABLE Funcionarios
DROP COLUMN Cpf

--Remover coluna
DROP TABLE Empresas

--Remover database
DROP DATABASE BancoTarde