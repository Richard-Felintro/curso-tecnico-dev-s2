-- DDL - Data Definition Language
CREATE DATABASE Exercicio_1_0

USE Exercicio_1_0

CREATE TABLE Genero
(
	IdGenero INT PRIMARY KEY IDENTITY,
	NomeGenero VARCHAR(32)
)

CREATE TABLE Filme
(
	IdFilme INT PRIMARY KEY IDENTITY,
	IdGenero INT FOREIGN KEY REFERENCES Genero(IdGenero),
	NomeFilme VARCHAR(64)
)