-- DDL - Data Defition Language
-- Um registro de aluguel deve conter qual cliente alugou, o veículo alugado, data de retirada e data de devolução
CREATE DATABASE Exercicio_1_2
USE Exercicio_1_2

CREATE TABLE Cliente
(
	IdCliente INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(32) NOT NULL,
	Cpf CHAR(11) NOT NULL,
)

CREATE TABLE Empresa
(
	IdEmpresa INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(32) NOT NULL UNIQUE
)

CREATE TABLE Marca
(
	IdMarca INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(32) NOT NULL UNIQUE
)

CREATE TABLE Modelo
(
	IdModelo INT PRIMARY KEY IDENTITY,
	IdMarca INT FOREIGN KEY REFERENCES Marca(IdMarca),
	Nome VARCHAR(32) NOT NULL UNIQUE
)

DROP TABLE Veiculo

CREATE TABLE Veiculo
(
	IdVeiculo INT PRIMARY KEY IDENTITY,
	IdModelo INT FOREIGN KEY REFERENCES Modelo(IdModelo) NOT NULL,
	IdEmpresa INT FOREIGN KEY REFERENCES Empresa(IdEmpresa) NOT NULL
)

DROP TABLE Aluguel

CREATE TABLE Aluguel
(
	IdAluguel INT PRIMARY KEY IDENTITY,
	IdCliente INT FOREIGN KEY REFERENCES Cliente(IdCliente),
	IdVeiculo INT FOREIGN KEY REFERENCES Veiculo(IdVeiculo),
	DataRetirada DATE,
	DataDevolucao DATE,
)

SELECT * FROM Cliente
SELECT * FROM Empresa
SELECT * FROM Aluguel
SELECT * FROM Marca
SELECT * FROM Modelo
SELECT * FROM Veiculo