USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_tipomotor','p') IS NOT NULL
		DROP PROCEDURE sp_select_tipomotor;
GO

CREATE PROCEDURE sp_select_tipomotor
@id_tipo_motor INT
AS
SELECT id_tipo_motor, id_tipo_motor_real, dsc_tipo_motor
FROM Tipomotor
WHERE id_tipo_motor = @id_tipo_motor
AND flg_ativo = 1