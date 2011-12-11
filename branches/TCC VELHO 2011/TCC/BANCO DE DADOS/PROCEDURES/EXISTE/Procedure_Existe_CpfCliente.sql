USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_cpf_cliente', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_cpf_cliente; 
GO 

CREATE PROCEDURE sp_existe_cpf_cliente
@cpf VARCHAR(15)
AS

SELECT COUNT(cpf) as flg_existe
FROM Cliente
WHERE cpf LIKE @cpf
AND flg_ativo = 1