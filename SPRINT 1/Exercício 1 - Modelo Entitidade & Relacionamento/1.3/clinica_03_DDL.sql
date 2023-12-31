-- DDL Data Definition Language
-- Cada atendimento deve registrar qual veterinário atendeu, qual pet foi atendido, descrição da consulta e data da consulta

CREATE DATABASE Exercicio_1_3

USE Exercicio_1_3

CREATE TABLE Dono
(
	IdDono INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(16) NOT NULL
)

CREATE TABLE Clinica
(
	IdClinica INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(16) NOT NULL,
	Endereco VARCHAR(48) NOT NULL
)

CREATE TABLE Veterinario
(
	IdVeterinario INT PRIMARY KEY IDENTITY,
	IdClinica INT FOREIGN KEY REFERENCES Clinica(IdClinica),
	Nome VARCHAR(24) NOT NULL,
	Crmv VARCHAR(10) NOT NULL
)

CREATE TABLE Tipo
(
	IdTipo INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(32) NOT NULL
)

CREATE TABLE Raca
(
	IdRaca INT PRIMARY KEY IDENTITY,
	IdTipo INT FOREIGN KEY REFERENCES Tipo(IdTipo),
	Nome VARCHAR(32) NOT NULL
)

CREATE TABLE Pet
(
	IdPet INT PRIMARY KEY IDENTITY,
	IdRaca INT FOREIGN KEY REFERENCES Raca(IdRaca),
	IdDono INT FOREIGN KEY REFERENCES Dono(IdDono),
	Nome VARCHAR(16) NOT NULL,
	DataNascimento DATE NOT NULL
)

CREATE TABLE Atendimento
(
	IdAtendimento INT PRIMARY KEY IDENTITY,
	IdPet INT FOREIGN KEY REFERENCES Pet(IdPet),
	IdVeterinario INT FOREIGN KEY REFERENCES Veterinario(IdVeterinario),
	DataConsulta DATE,
	Descricao VARCHAR(64)
)
