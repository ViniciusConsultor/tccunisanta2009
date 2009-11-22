USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_fornecedor_ident_inter', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_fornecedor_ident_inter; 
GO 

CREATE PROCEDURE sp_existe_fornecedor_ident_inter
@ident_inter VARCHAR(15)
AS

SELECT COUNT(ident_inter) as flg_existe
FROM Fornecedor
WHERE ident_inter LIKE @ident_inter
AND flg_ativo = 1