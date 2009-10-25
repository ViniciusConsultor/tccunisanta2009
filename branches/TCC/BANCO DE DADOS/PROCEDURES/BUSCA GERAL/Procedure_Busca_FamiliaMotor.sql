USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_familiaMotor','p') IS NOT NULL
		DROP PROCEDURE sp_busca_familiaMotor;
GO
CREATE PROCEDURE sp_busca_familiaMotor
AS 
SELECT id_fam_motor, dsc_fam_motor 'Familia Motor' FROM Familiamotor
WHERE flg_ativo = 1