--DML DATA MANIPULATION LANGUAGE

USE Exercicio_1_1

INSERT INTO Pessoa(Nome, CNH)
VALUES('Joaquin','1234567890')

INSERT INTO Pessoa VALUES('Ednelson','0987654321'),('Joaquin','1234567890'),('Pedro','1231231230')

INSERT INTO Email VALUES(1,'ednelson@gmail.com'),(2,'joaquin123@gmail.com'),(3,'p300@gmail.com')

INSERT INTO Telefone VALUES (1,'939578930'),(2,'123456789'),(3,'987654321')

SELECT * FROM Pessoa
SELECT * FROM Telefone
SELECT * FROM Email