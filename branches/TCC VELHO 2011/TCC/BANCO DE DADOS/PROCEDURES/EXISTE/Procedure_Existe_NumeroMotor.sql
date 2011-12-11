USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_numeroMotor', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_numeroMotor; 
GO 

CREATE PROCEDURE sp_existe_numeroMotor
@id_num_motor_real VARCHAR(50)
AS

SELECT COUNT(id_num_motor_real) as flg_existe
FROM Numeromotor
WHERE id_num_motor_real LIKE @id_num_motor_real
AND flg_ativo = 1