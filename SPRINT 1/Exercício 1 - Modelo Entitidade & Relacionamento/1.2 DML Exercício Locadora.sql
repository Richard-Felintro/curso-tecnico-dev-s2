-- DDL - Data Defition Language
-- Um registro de aluguel deve conter qual cliente alugou, o veículo alugado, data de retirada e data de devolução
USE Exercicio_1_2

INSERT INTO Empresa VALUES ('Juninho Locadora'),('João e Pedro Locadora')

INSERT INTO Cliente VALUES ('Joana','12345678901'),('Gutinelson','10987654321'),('Edaurdo','12312312312')

INSERT INTO Marca VALUES ('Wolkswagen'),('Fiat'),('Toyota')

INSERT INTO Modelo VALUES (3,'Toyota Corolla'),(2,'Fiat Uno'),(1,'Polo')

INSERT INTO Aluguel VALUES (1,3,'02-08-2023','11-09-2023'),(2,2,'01-08-2023','01-09-2023'),(3,1,'23-07-2023','13-08-2023')

INSERT INTO Veiculo VALUES (2,1),(3,1),(1,3)


SELECT * FROM Cliente
SELECT * FROM Aluguel
SELECT * FROM Modelo
SELECT * FROM Veiculo
SELECT * FROM Empresa
SELECT * FROM Marca