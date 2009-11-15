USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_familiaMotor', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_familiaMotor; 
GO 

CREATE PROCEDURE sp_existe_familiaMotor
@id_fam_motor_real VARCHAR(20)
AS

SELECT COUNT(id_fam_motor_real) as flg_existe
FROM Familiamotor
WHERE id_fam_motor_real LIKE @id_fam_motor_real
AND flg_ativo = 1