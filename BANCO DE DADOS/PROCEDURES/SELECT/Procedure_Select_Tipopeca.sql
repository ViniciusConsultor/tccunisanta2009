USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_tipopeca','p') IS NOT NULL
		DROP PROCEDURE sp_select_tipopeca;
GO

CREATE PROCEDURE sp_select_tipopeca
@id_tipo_peca INT
AS
SELECT id_tipo_peca, dsc_tipo_peca, flg_ativo
FROM Tipopeca
WHERE id_tipo_peca = @id_tipo_peca
AND flg_ativo = 1