-- DQL - Data Query Language
USE Exercicio_1_4

-- listar todos os usu�rios administradores, sem exibir suas senhas
SELECT
U.Nome

FROM
Usuario AS U
WHERE
U.PermissaoAdmin = 1


-- listar todos os �lbuns lan�ados ap�s o um determinado ano de lan�amento
SELECT
A.Titulo,
A.DataLancamento,
A.Duracao

FROM
Album AS A
WHERE 
A.DataLancamento >= '25-12-2006'


-- listar os dados de um usu�rio atrav�s do e-mail e senha
SELECT
U.Nome,
E.Endereco,
U.Senha

FROM
Usuario AS U
LEFT JOIN Email AS E ON U.IdUsuario = E.IdUsuario

WHERE
E.Endereco = 'pedrinho@pedro' AND U.Senha = '12345678'


-- listar todos os �lbuns ativos, mostrando o nome do artista e os estilos do �lbum 
SELECT
Album.Titulo AS T�tulo,
Artista.Nome AS Artista,
Estilo.Nome  AS Estilo

FROM
Album LEFT JOIN Artista ON Album.IdArtista = Artista.IdArtista
      LEFT JOIN Estilo  ON Estilo.IdEstilo = Album.IdEstilo

WHERE
Album.Disponivel = 1