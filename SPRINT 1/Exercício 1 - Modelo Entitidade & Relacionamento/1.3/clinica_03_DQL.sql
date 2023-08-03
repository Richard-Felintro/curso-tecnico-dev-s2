-- DQL - Data Query Language
USE Exercicio_1_3
-- listar todos os veterin�rios (nome e CRMV) de uma cl�nica (raz�o social)

SELECT
V.Nome AS Nome,
V.CRMV AS CRMV,
C.Nome AS Cl�nica

FROM 
Veterinario AS V
LEFT JOIN Clinica AS C ON V.IdClinica = C.IdClinica

WHERE
V.IdClinica = 2


-- listar todas as ra�as que come�am com a letra S

SELECT * FROM Raca

SELECT
R.Nome AS Ra�a,
T.Nome AS Tipo

FROM
Raca AS R
LEFT JOIN Tipo AS T ON R.IdTipo = T.IdTipo
WHERE R.Nome LIKE 'S%'


-- listar todos os tipos de pet que terminam com a letra O

SELECT
P.Nome AS Nome,
R.Nome AS Ra�a,
T.Nome AS Tipo

FROM
Pet AS P
LEFT JOIN Raca AS R ON R.IdRaca = P.IdRaca
LEFT JOIN Tipo AS T ON R.IdTipo = T.IdTipo
WHERE P.Nome LIKE '%O'

-- listar todos os pets mostrando os nomes dos seus donos

SELECT
P.Nome AS 'Nome do Pet',
R.Nome AS 'Ra�a',
T.Nome AS 'Tipo',
D.Nome AS 'Nome do Dono'

FROM
Pet AS P
LEFT JOIN Raca AS R ON R.IdRaca = P.IdRaca
LEFT JOIN Tipo AS T ON R.IdTipo = T.IdTipo
LEFT JOIN Dono AS D ON P.IdDono = D.IdDono

/* listar todos os atendimentos mostrando o nome do veterin�rio que atendeu, o nome,
a ra�a e o tipo do pet que foi atendido, o nome do dono do pet e o nome da cl�nica onde o pet foi atendido */

SELECT
V.Nome AS 'Veterin�rio Respons�vel',
P.Nome AS 'Pet Atendido',
R.Nome AS Ra�a,
T.Nome AS Tipo,
D.Nome AS 'Dono do Paciente',
C.Nome AS 'Cl�nica'

FROM
Atendimento AS A
LEFT JOIN Veterinario AS V ON A.IdVeterinario = V.IdVeterinario
LEFT JOIN Pet         AS P ON A.IdPet         = P.IdPet
LEFT JOIN Raca        AS R ON R.IdRaca        = P.IdRaca
LEFT JOIN Tipo        AS T ON T.IdTipo        = R.IdTipo
LEFT JOIN Dono        AS D ON D.IdDono        = P.IdDono
LEFT JOIN Clinica     AS C ON C.IdClinica     = V.IdClinica