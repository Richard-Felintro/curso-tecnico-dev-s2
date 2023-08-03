-- DML Data Manipulation Language
-- Cada atendimento deve registrar qual veterinário atendeu, qual pet foi atendido, descrição da consulta e data da consulta

USE Exercicio_1_3

INSERT INTO Dono VALUES ('Eduardo'),('Eduardois'),('3duardo')

INSERT INTO Clinica VALUES ('Pets do Mal','Rua dos Bobos 0'),('Pershop Genérico','Rua Comum 150')

INSERT INTO Veterinario VALUES (1,'Joaquinson III','RJ 15361'),(2,'João','SP 036547'),(2,'Maria','BA 2463')

INSERT INTO Tipo VALUES ('Cachorro'),('Gato'),('Peixe')

INSERT INTO Raca VALUES (1,'Pug'),(1,'Labrador'),(2,'Persa'),(3,'Peixinho Dourado'),(1,'Sachorro'),(2,'Sato'),(3,'Seixe')

INSERT INTO Pet VALUES (1,1,'Luna','2022-05-07'),(2,2,'Rex','2013-09-15'),(4,3,'Nyarlathotep','0233-12-22'),(2,1,'Gato','2018-05-03')

SELECT * FROM Pet

INSERT INTO Atendimento VALUES 
(1,3,'01-08-2023','Cirurgia, cauda removida'),
(2,2,'23-07-2023','Banho e tosa'),
(3,1,'04-01-2024','Tentativa de contenção, Pet perdido no processo')


SELECT * FROM Dono
SELECT * FROM Clinica
SELECT * FROM Veterinario
SELECT * FROM Tipo
SELECT * FROM Raca
SELECT * FROM Pet
SELECT * FROM Atendimento