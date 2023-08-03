-- DQL - Data Query Language
-- listar as pessoas em ordem alfabética reversa, mostrando seus telefones, seus e-mails e suas CNHs

USE Exercicio_1_1

SELECT 
P.Nome AS Nome,
Telefone.Numero AS Telefone,
E.Endereco AS Email,
P.CNH AS CNH

FROM 
Pessoa AS P,
Email AS E,
Telefone

WHERE P.IdPessoa = E.IdPessoa AND P.IdPessoa = Telefone.IdPessoa
ORDER BY Nome DESC

INSERT INTO Pessoa VALUES
('Pedro','1234321'),
('Jonas','4321234'),
('Junimo','abcdefg'),
('Ednelson','1234abc')