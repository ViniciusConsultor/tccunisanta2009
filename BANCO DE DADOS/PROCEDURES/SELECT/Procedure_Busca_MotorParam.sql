USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_motor_param','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_motor_param;
GO
CREATE PROCEDURE sp_busca_motor_param
@dsc_motor_compra AS VARCHAR(100)
AS 
SELECT id_motor, dsc_motor 'Motor'
FROM motor 
WHERE dsc_motor like @dsc_motor_compra + '%'