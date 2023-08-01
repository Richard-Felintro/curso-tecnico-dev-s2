--DDL - Data Definition Language

CREATE DATABASE Exercicio_1_4
USE Exercicio_1_4

CREATE TABLE Estilo
(
	IdEstilo INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(32)
)

CREATE TABLE Usuario
(
	IdUsuario INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(24),
)