-- DQL - Data Query Language
USE Exercicio_1_6

/* Listar todos os pedidos dos clientes */
SELECT
Cliente.Nome AS 'Cliente',
Tipo.Nome AS 'Tipo de Eletr�nico',
Especialista.Nome AS 'Especialista Respons�vel',
Empresa.Nome AS 'Empresa Respons�vel'

FROM
Conserto
LEFT JOIN Eletronico ON Conserto.IdEletronico = Eletronico.IdEletronico
LEFT JOIN Tipo ON Eletronico.IdTipo = Tipo.IdTipo
LEFT JOIN Cliente ON Eletronico.IdCliente = Cliente.IdCliente
LEFT JOIN Especialista ON Especialista.IdEspecialista = Conserto.IdEspecialista
LEFT JOIN Empresa ON Empresa.IdEmpresa = Especialista.IdEmpresa


/* Listar todos os pedidos de um determinado cliente, 
mostrando quais foram os colaboradores que executaram o servi�o, 
qual foi o tipo de conserto, qual item foi consertado e o nome deste cliente */

SELECT
Cliente.Nome AS 'Cliente',
Tipo.Nome AS 'Tipo de Eletr�nico',
Especialista.Nome AS 'Especialista Respons�vel',
Empresa.Nome AS 'Empresa Respons�vel'

FROM
Conserto
LEFT JOIN Eletronico ON Conserto.IdEletronico = Eletronico.IdEletronico
LEFT JOIN Tipo ON Eletronico.IdTipo = Tipo.IdTipo
LEFT JOIN Cliente ON Eletronico.IdCliente = Cliente.IdCliente
LEFT JOIN Especialista ON Especialista.IdEspecialista = Conserto.IdEspecialista
LEFT JOIN Empresa ON Empresa.IdEmpresa = Especialista.IdEmpresa

WHERE
Cliente.IdCliente = 1