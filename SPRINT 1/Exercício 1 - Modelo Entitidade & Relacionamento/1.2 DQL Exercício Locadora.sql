-- DQL Data Query Language

USE Exercicio_1_2
SELECT * FROM Aluguel

-- Listar todos os alugueis mostrando as datas de início e fim, o nome do cliente que alugou e nome do modelo do carro
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
V.IdVeiculo = A.IdVeiculo


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
C.IdCliente = 3
