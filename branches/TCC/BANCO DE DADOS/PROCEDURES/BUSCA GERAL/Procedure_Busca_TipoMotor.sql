USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_tipoMotor','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_tipoMotor;
GO
CREATE PROCEDURE sp_busca_tipoMotor
AS
SELECT id_tipo_motor, id_tipo_motor_real, dsc_tipo_motor
FROM Tipomotor
WHERE flg_ativo = 1