USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_kitgrupopeca','p') IS NOT NULL
		DROP PROCEDURE sp_select_kitgrupopeca;
GO

CREATE PROCEDURE sp_select_kitgrupopeca
@id_kit INT
AS
SELECT id_kit, id_kit_real, nom, dat_alt, flg_ativo
FROM Kitgrupopeca
WHERE id_kit = @id_kit
AND flg_ativo = 1