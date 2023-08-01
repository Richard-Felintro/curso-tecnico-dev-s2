--DML Data Manipulation Language

USE BancoTarde

--Adicionar objeto
INSERT INTO Funcionarios(Nome)
VALUES('Eduardo')

--Modificar objeto
UPDATE Funcionarios
SET Nome = 'Guti'

--Condicionais para update
UPDATE Funcionarios SET Nome = 'ETINSPARDO' WHERE IdFuncionario = 12

--Condicionais para deletar
DELETE FROM Funcionarios WHERE IdFuncionario = 3

--Foreign Keys
INSERT INTO Empresas(IdFuncionario,Nome)
VALUES (12,'Macrohard')