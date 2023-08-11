-- DQL - Data Query Language
USE Exercicio_1_0

SELECT
Filme.NomeFilme AS 'Filme',
Genero.NomeGenero AS 'Gênero'

FROM Filme
LEFT JOIN Genero ON Filme.IdGenero = Genero.IdGenero

UPDATE Genero SET NomeGenero = 'Comédia' WHERE IdGenero = 3