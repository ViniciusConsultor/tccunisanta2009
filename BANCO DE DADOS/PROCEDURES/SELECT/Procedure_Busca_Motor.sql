USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_motor','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_motor;
GO
CREATE PROCEDURE sp_busca_motor
AS
<<<<<<< .mine
SELECT id_motor, dsc_motor 'Motor' FROM motor
=======
SELECT id_motor_compra, dsc_motor_compra as 'Descrição do motor' fROM motor
>>>>>>> .r88
