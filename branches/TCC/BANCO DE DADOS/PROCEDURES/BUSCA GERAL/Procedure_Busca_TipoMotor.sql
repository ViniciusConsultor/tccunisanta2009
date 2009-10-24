USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_tipoMotor','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_tipoMotor;
GO
CREATE PROCEDURE sp_busca_tipoMotor
AS
SELECT id_tipo_motor, dsc_tipo_motor 'Tipo Motor'
FROM Tipomotor