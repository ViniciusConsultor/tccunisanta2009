USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_estoque', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_estoque; 
GO 

CREATE PROCEDURE sp_existe_estoque
@dsc_estoq VARCHAR(100)
AS

SELECT COUNT(dsc_estoq) as flg_existe
FROM Estoque
WHERE dsc_estoq LIKE @dsc_estoq
AND flg_ativo = 1