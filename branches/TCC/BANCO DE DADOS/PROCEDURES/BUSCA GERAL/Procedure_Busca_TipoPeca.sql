USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_tipoPeca','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_tipoPeca;
GO
CREATE PROCEDURE sp_busca_tipoPeca
AS
SELECT id_tipo_peca, dsc_tipo_peca FROM Tipopeca
WHERE flg_ativo = 1