USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_cnpj_cliente', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_cnpj_cliente; 
GO 

CREATE PROCEDURE sp_existe_cnpj_cliente
@cnpj NUMERIC(15,0)
AS

SELECT COUNT(cnpj) as flg_existe
FROM Cliente
WHERE cnpj LIKE @cnpj
AND flg_ativo = 1