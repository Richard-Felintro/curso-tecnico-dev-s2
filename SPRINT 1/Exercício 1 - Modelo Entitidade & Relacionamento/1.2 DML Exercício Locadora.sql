--DDL - Data Defition Language
USE Exercicio_1_2

INSERT INTO Empresa VALUES ('Juninho Locadora'),('João e Pedro Locadora')

INSERT INTO Cliente VALUES ('Joana','12345678901'),('Gutinelson','10987654321'),('Edaurdo','12312312312')

INSERT INTO Marca VALUES ('Wolkswagen'),('Fiat'),('Toyota')

INSERT INTO Modelo VALUES (3,'Toyota Corolla'),(2,'Fiat Uno'),(1,'Polo')

INSERT INTO Aluguel VALUES (1),(2),(3)

INSERT INTO Veiculo VALUES (1,2,1),(2,3,1),(3,1,3)


SELECT * FROM Cliente
SELECT * FROM Aluguel
SELECT * FROM Modelo
SELECT * FROM Veiculo
SELECT * FROM Empresa
SELECT * FROM Marca