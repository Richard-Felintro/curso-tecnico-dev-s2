CREATE DATABASE FilmesTarde
USE FilmesTarde

CREATE TABLE Genero
(
	IdGenero INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50)
)

CREATE TABLE Filme
(
	IdFilme INT PRIMARY KEY IDENTITY,
	IdGenero INT FOREIGN KEY REFERENCES Genero(IdGenero),
	Titulo VARCHAR(50)
)
DROP TABLE Usuario
CREATE TABLE Usuario
(
	IdUsuario INT PRIMARY KEY IDENTITY,
	UserName VARCHAR(32) NOT NULL,
	Email VARCHAR(128) UNIQUE NOT NULL,
	Senha VARCHAR(32) NOT NULL,
	PermissaoAdmin BIT NOT NULL DEFAULT 0
)

SELECT * FROM Filme
SELECT Filme.IdFilme, Filme.Titulo, Genero.IdGenero, Genero.Nome FROM Filme LEFT JOIN Genero ON Genero.IdGenero = Filme.IdGenero WHERE IdFilme = 1