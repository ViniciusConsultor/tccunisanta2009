USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_numeromotor','p') IS NOT NULL
		DROP PROCEDURE sp_select_numeromotor;
GO

CREATE PROCEDURE sp_select_numeromotor
@id_num_motor INT
AS
SELECT id_num_motor, dsc_num_motor
FROM Numeromotor
WHERE id_num_motor = @id_num_motor