-- DQL Data Query Language

USE Exercicio_1_2

-- Listar todos os alugueis mostrando as datas de início e fim, o nome do cliente que alugou e nome do modelo do carro

SELECT * FROM Veiculo

SELECT

Cliente.Nome AS Cliente,
Modelo.Nome AS Modelo,
Aluguel.DataRetirada AS 'Data de Retirada',
Aluguel.DataDevolucao AS 'Data de Devolução'


FROM Aluguel 
LEFT JOIN Cliente ON Cliente.IdCliente = Aluguel.IdCliente
LEFT JOIN Veiculo ON Aluguel.IdVeiculo = Veiculo.IdVeiculo
LEFT JOIN Modelo  ON Modelo.IdModelo   = Veiculo.IdModelo

-- Listar os alugueis de um determinado cliente mostrando seu nome, as datas de início e fim e o nome do modelo do carro

SELECT

Cliente.Nome AS Cliente,
Modelo.Nome AS Modelo,
Aluguel.DataRetirada AS 'Data de Retirada',
Aluguel.DataDevolucao AS 'Data de Devolução'


FROM Aluguel 
LEFT JOIN Cliente ON Cliente.IdCliente = Aluguel.IdCliente
LEFT JOIN Veiculo ON Aluguel.IdVeiculo = Veiculo.IdVeiculo
LEFT JOIN Modelo  ON Modelo.IdModelo   = Veiculo.IdModelo
WHERE Cliente.IdCliente = 1
-- WHERE Cliente.Nome = 'Joana'    Também funciona


-- VERSÃO ANTIGA SEM USAR JOIN

-- Listar todos os alugueis mostrando as datas de início e fim, o nome do cliente que alugou e nome do modelo do carro

/*SELECT
C.Nome AS Cliente,
M.Nome AS Modelo,
A.DataRetirada AS 'Data de Retirada',
A.DataDevolucao AS 'Data de Devolução'

FROM
Cliente AS C,
Aluguel AS A,
Veiculo AS V,
Modelo  AS M




-- Listar os alugueis de um determinado cliente mostrando seu nome, as datas de início e fim e o nome do modelo do carro
SELECT
C.Nome AS Cliente,
M.Nome AS Modelo,
A.DataRetirada AS 'Data de Retirada',
A.DataDevolucao AS 'Data de Devolução'

FROM
Cliente AS C,
Aluguel AS A,
Veiculo AS V,
Modelo  AS M

WHERE 
C.IdCliente = A.IdCliente AND
M.IdModelo  = V.IdModelo AND
V.IdVeiculo = A.IdVeiculo AND
C.IdCliente = 3*/