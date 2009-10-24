USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_familiamotor','p') IS NOT NULL
		DROP PROCEDURE sp_select_familiamotor;
GO

CREATE PROCEDURE sp_select_familiamotor
@id_fam_motor INT
AS
SELECT id_fam_motor, id_num_motor, id_grupo, id_tipo_motor, flg_ativo, id_motor, id_estoque
FROM Familimotor
WHERE id_fam_motor = @id_fam_motor