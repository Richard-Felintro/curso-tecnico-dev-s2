-- DQL - Data Query Language
USE Exercicio_1_0

SELECT
Filme.NomeFilme AS 'Filme',
Genero.NomeGenero AS 'G�nero'

FROM Filme
LEFT JOIN Genero ON Filme.IdGenero = Genero.IdGenero

UPDATE Genero SET NomeGenero = 'Com�dia' WHERE IdGenero = 3