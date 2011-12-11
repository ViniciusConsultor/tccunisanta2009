USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_kitfamilia','p') IS NOT NULL
		DROP PROCEDURE sp_select_kitfamilia;
GO

CREATE PROCEDURE sp_select_kitfamilia
@id_fam_motor INT,
@id_kit INT
AS
SELECT id_fam_motor, id_kit, flg_ativo, dat_alt
FROM kitfamilia
WHERE id_fam_motor = @id_fam_motor and id_kit = @id_kit
AND flg_ativo = 1