-- DQL - Data Query Language
USE Exercicio_1_4

-- listar todos os usuários administradores, sem exibir suas senhas
SELECT
U.Nome

FROM
Usuario AS U
WHERE
U.PermissaoAdmin = 1


-- listar todos os álbuns lançados após o um determinado ano de lançamento
SELECT
A.Titulo,
A.DataLancamento,
A.Duracao

FROM
Album AS A
WHERE 
A.DataLancamento >= '25-12-2006'


-- listar os dados de um usuário através do e-mail e senha
SELECT
U.Nome,
E.Endereco,
U.Senha

FROM
Usuario AS U
LEFT JOIN Email AS E ON U.IdUsuario = E.IdUsuario

WHERE
E.Endereco = 'pedrinho@pedro' AND U.Senha = '12345678'


-- listar todos os álbuns ativos, mostrando o nome do artista e os estilos do álbum 
SELECT
Album.Titulo AS Título,
Artista.Nome AS Artista,
Estilo.Nome  AS Estilo

FROM
Album LEFT JOIN Artista ON Album.IdArtista = Artista.IdArtista
      LEFT JOIN Estilo  ON Estilo.IdEstilo = Album.IdEstilo

WHERE
Album.Disponivel = 1