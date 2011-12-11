USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_tipoMotor', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_tipoMotor; 
GO 

CREATE PROCEDURE sp_existe_tipoMotor
@id_tipo_motor_real VARCHAR(50)
AS

SELECT COUNT(id_tipo_motor_real) as flg_existe
FROM Tipomotor
WHERE id_tipo_motor_real LIKE @id_tipo_motor_real
AND flg_ativo = 1