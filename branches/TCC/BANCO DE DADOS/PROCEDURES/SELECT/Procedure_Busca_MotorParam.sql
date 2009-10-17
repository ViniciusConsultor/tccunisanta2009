USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_motor_param','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_motor_param;
GO
CREATE PROCEDURE sp_busca_motor_param
@dsc_motor_compra AS VARCHAR(100)
AS 
SELECT id_motor_compra, dsc_motor_compra as	'Descrição do motor'
FROM motor 
WHERE dsc_motor_compra like @dsc_motor_compra + '%'