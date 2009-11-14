USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_tipoPeca', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_tipoPeca; 
GO 

CREATE PROCEDURE sp_existe_tipoPeca
@dsc_tipo_peca VARCHAR(25)
AS

SELECT COUNT(dsc_tipo_peca) as flg_existe
FROM Tipopeca
WHERE dsc_tipo_peca LIKE @dsc_tipo_peca
AND flg_ativo = 1