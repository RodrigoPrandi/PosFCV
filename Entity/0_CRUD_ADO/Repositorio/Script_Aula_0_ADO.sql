
--Criar banco BancoADO

CREATE TABLE Funcionario
(
	Id int identity(1,1),
	Nome Varchar(200),
	Salario numeric(10,2)
)

GO

INSERT INTO Funcionario VALUES('Carlos',10000)
INSERT INTO Funcionario VALUES('Maria',1000)
INSERT INTO Funcionario VALUES('José',5000)

GO

CREATE PROCEDURE SELECIONAR_FUNCIONARIO
AS
(
SELECT
	Id,
	Nome,
	Salario
FROM
	Funcionario
)

GO

CREATE PROCEDURE INSERE_FUNCIONARIO
(
@Nome nvarchar(200),
@Salario numeric(10,2)
)
AS
BEGIN
INSERT INTO Funcionario
(
Nome,
Salario
) 
VALUES
(
@Nome,
@Salario
)
END

GO

CREATE PROCEDURE ALTERA_FUNCIONARIO
(
@Id int,
@Nome nvarchar(200),
@Salario numeric(10,2)
)
AS
BEGIN
UPDATE Funcionario
SET
	Nome = @Nome,
	Salario = @Salario
WHERE
	Id = @Id
END
GO 

CREATE PROCEDURE EXCLUIR_FUNCIONARIO
@Id int
AS
BEGIN
	DELETE 
		Funcionario
	WHERE 
		Id = @Id
END
