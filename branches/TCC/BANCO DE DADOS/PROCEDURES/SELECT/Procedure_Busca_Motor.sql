USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_motor','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_motor;
GO
CREATE PROCEDURE sp_busca_motor
AS
SELECT id_motor, dsc_motor 'Motor' FROM Motor
