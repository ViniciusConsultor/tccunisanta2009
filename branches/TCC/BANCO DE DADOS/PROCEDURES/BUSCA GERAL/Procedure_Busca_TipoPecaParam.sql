USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_tipoPeca_param','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_tipoPeca_param;
GO
CREATE PROCEDURE sp_busca_tipoPeca_param
@dsc_tipo_peca VARCHAR(500)
AS
SELECT id_tipo_peca, dsc_tipo_peca
FROM Tipopeca
WHERE dsc_tipo_peca LIKE '%' + @dsc_tipo_peca  + '%'
AND flg_ativo = 1
