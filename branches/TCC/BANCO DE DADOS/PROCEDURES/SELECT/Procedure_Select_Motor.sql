USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_motor','p') IS NOT NULL
		DROP PROCEDURE sp_select_motor;
GO

CREATE PROCEDURE sp_select_motor
@id_motor INT
AS
SELECT id_motor, dsc_motor, flg_ativo
FROM Motor
WHERE id_motor = @id_motor