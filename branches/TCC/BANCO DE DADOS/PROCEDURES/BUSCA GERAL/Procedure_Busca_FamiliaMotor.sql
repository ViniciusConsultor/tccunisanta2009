USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_familiaMotor','p') IS NOT NULL
		DROP PROCEDURE sp_busca_familiaMotor;
GO
CREATE PROCEDURE sp_busca_familiaMotor
AS 
SELECT id_fam_motor as 'Id', id_fam_motor_real 'Codigo', dsc_fam_motor 'Nome', 0 as 'Qtd' FROM Familiamotor
WHERE flg_ativo = 1