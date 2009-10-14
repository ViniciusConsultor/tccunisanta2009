USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_tipodepeca_param','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_tipodepeca_param;
GO
CREATE PROCEDURE sp_busca_tipodepeca_param
@dsc_tipo_peca VARCHAR(500)
AS
SELECT id_tipo_peca, dsc_tipo_peca 
FROM Tipodepeca
WHERE dsc_tipo_peca LIKE @dsc_tipo_peca  + '%'