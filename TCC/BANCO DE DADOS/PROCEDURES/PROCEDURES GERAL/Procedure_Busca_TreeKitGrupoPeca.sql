USE Megatechdatabase
GO

IF OBJECT_ID('sp_busca_tree_kitgrupopeca','p') IS NOT NULL
		DROP PROCEDURE sp_busca_tree_kitgrupopeca;
GO

CREATE PROCEDURE sp_busca_tree_kitgrupopeca
@id_kit INT
AS
SELECT id_kit, id_kit_real, nom, flg_ativo, dat_alt
FROM kitgrupopeca
WHERE id_kit = @id_kit
AND flg_ativo = 1