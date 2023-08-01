--DML Data Manipulation Language
USE Exercicio_1_3

INSERT INTO Dono VALUES ('Eduardo'),('Eduardois'),('3duardo')

INSERT INTO Clinica VALUES ('Pets do Mal','Rua dos Bobos 0'),('Pershop Genérico','Rua Comum 150')

INSERT INTO Veterinario VALUES (1,'Joaquinson III'),(2,'João'),(2,'Maria')

INSERT INTO Tipo VALUES ('Cachorro'),('Gato'),('Peixe')

INSERT INTO Raca VALUES (1,'Pug'),(1,'Labrador'),(2,'Persa'),(3,'Peixinho Dourado')

INSERT INTO Pet VALUES (1,1,'Luna','2022-05-07'),(2,2,'Rex','2013-09-15'),(4,3,'Nyarlathotep','0233-12-22')

INSERT INTO Atendimento VALUES (1,3),(2,2),(3,1)


SELECT * FROM Dono
SELECT * FROM Clinica
SELECT * FROM Veterinario
SELECT * FROM Tipo
SELECT * FROM Raca
SELECT * FROM Pet
SELECT * FROM Atendimento