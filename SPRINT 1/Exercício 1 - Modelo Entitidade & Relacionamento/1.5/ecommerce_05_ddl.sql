-- DDL - Data Definition Language

CREATE DATABASE Exercicio_1_5
USE Exercicio_1_5

CREATE TABLE Loja
(
	IdLoja INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(64)
)

CREATE TABLE Categoria
(
	IdCategoria INT PRIMARY KEY IDENTITY,
	IdLoja INT FOREIGN KEY REFERENCES Loja(IdLoja),
	Nome VARCHAR(64)
)

CREATE TABLE Subcategoria
(
	IdSubcategoria INT PRIMARY KEY IDENTITY,
	IdCategoria INT FOREIGN KEY REFERENCES Categoria(IdCategoria),
	Nome VARCHAR(64)
)

CREATE TABLE Produto
(
	IdProduto INT PRIMARY KEY IDENTITY,
	IdSubcategoria INT FOREIGN KEY REFERENCES Subcategoria(IdSubcategoria),
	Nome VARCHAR(64)
)

CREATE TABLE Cliente
(
	IdCliente INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(64),
	Email VARCHAR(64),
	Senha VARCHAR(16)
)

CREATE TABLE Pedido
(
	IdPedido INT PRIMARY KEY IDENTITY,
	IdCliente INT FOREIGN KEY REFERENCES Cliente(IdCliente),
	IdProduto INT FOREIGN KEY REFERENCES Produto(IdProduto),
)