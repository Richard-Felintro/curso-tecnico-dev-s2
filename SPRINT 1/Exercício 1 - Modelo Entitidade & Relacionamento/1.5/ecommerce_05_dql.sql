-- DQL - Data Query Language

/* Listar todos os pedidos de um cliente (nome), 
 mostrando quais produtos foram solicitados (titulo) neste pedido
 e de qual subcategoria (nome) e categoria (nome) pertencem */

USE Exercicio_1_5

SELECT
Cliente.Nome AS 'Cliente',
Categoria.Nome,
Subcategoria.Nome,
Produto.Nome AS 'Produto'

FROM Categoria
LEFT JOIN Subcategoria ON Categoria.IdCategoria = Subcategoria.IdCategoria
LEFT JOIN Produto  ON Produto.IdSubcategoria = Subcategoria.IdSubcategoria
LEFT JOIN Pedido  ON Pedido.IdProduto = Produto.IdProduto
LEFT JOIN Cliente ON Cliente.IdCliente = Pedido.IdCliente

WHERE Cliente.Nome = 'Irmão do Jorel'