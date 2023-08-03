-- DDL - Data Definition Language

CREATE DATABASE Exercicio_1_4
USE Exercicio_1_4

CREATE TABLE Empresa
(
	IdEmpresa INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(32),
)

CREATE TABLE Artista
(
	IdArtista INT PRIMARY KEY IDENTITY,
	IdEmpresa INT FOREIGN KEY REFERENCES Empresa(IdEmpresa),
	Nome VARCHAR(32)
)

CREATE TABLE Estilo
(
	IdEstilo INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(32)
)

CREATE TABLE Usuario
(
	IdUsuario INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(32),
	PermissaoAdmin BIT,
	Senha VARCHAR(16)
)

CREATE TABLE Email
(
	IdEmail INT PRIMARY KEY IDENTITY,
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
	Endereco VARCHAR(64)
)

CREATE TABLE Album
(
	IdAlbum INT PRIMARY KEY IDENTITY,
	IdArtista INT FOREIGN KEY REFERENCES Artista(IdArtista),
	IdEstilo INT FOREIGN KEY REFERENCES Estilo(IdEstilo),
	Titulo VARCHAR(64),
	DataLancamento DATE,
	Localizacao VARCHAR(64),
	Duracao TIME,
	Disponivel BIT,
)

CREATE TABLE Compra
(
	IdCompra INT PRIMARY KEY IDENTITY,
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
	IdAlbum INT FOREIGN KEY REFERENCES Album(IdAlbum)
)