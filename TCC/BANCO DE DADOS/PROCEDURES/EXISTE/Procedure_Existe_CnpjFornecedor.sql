USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_fornecedor_cnpj', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_fornecedor_cnpj; 
GO 

CREATE PROCEDURE sp_existe_fornecedor_cnpj
@cnpj VARCHAR(15)
AS

SELECT COUNT(cnpj) as flg_existe
FROM Fornecedor
WHERE cnpj LIKE @cnpj
AND flg_ativo = 1