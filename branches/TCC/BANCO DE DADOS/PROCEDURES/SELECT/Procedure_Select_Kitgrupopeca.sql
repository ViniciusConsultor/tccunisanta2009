USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_kitgrupopeca','p') IS NOT NULL
		DROP PROCEDURE sp_select_kitgrupopeca;
GO

CREATE PROCEDURE sp_select_kitgrupopeca
@id_grupo INT
AS
SELECT id_grupo, nom, flg_ativo, id_item_peca, id_peca, dat_alt
FROM Kitgrupopeca
WHERE id_grupo = @id_grupo