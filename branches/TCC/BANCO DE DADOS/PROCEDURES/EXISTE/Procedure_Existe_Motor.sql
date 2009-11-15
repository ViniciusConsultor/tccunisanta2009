USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_motor', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_motor; 
GO 

CREATE PROCEDURE sp_existe_motor
@dsc_motor VARCHAR(100)
AS

SELECT COUNT(dsc_motor) as flg_existe
FROM Motor
WHERE dsc_motor LIKE @dsc_motor
AND flg_ativo = 1