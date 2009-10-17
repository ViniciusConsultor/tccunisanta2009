USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_motor_param','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_motor_param;
GO
CREATE PROCEDURE sp_busca_motor_param
@dsc_motor_compra AS VARCHAR(100)
AS 
<<<<<<< .mine
SELECT id_motor, dsc_motor 'Motor'
=======
SELECT id_motor_compra, dsc_motor_compra as	'Descrição do motor'
>>>>>>> .r88
FROM motor 
WHERE dsc_motor like @dsc_motor_compra + '%'