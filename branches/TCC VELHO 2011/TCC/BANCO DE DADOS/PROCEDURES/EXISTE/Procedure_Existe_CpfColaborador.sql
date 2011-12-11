USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_cpf_colaborador', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_cpf_colaborador; 
GO 

CREATE PROCEDURE sp_existe_cpf_colaborador
@cpf VARCHAR(15)
AS

SELECT COUNT(cpf) as flg_existe
FROM Colaborador
WHERE cpf LIKE @cpf
AND flg_ativo = 1