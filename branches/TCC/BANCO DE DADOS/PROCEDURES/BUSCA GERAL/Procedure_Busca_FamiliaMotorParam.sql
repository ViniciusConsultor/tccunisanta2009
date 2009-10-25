USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_familiaMotor_param','p') IS NOT NULL
		DROP PROCEDURE sp_busca_familiaMotor_param;
GO
CREATE PROCEDURE sp_busca_familiaMotor_param
@dsc_fam_motor VARCHAR(500)
AS 
SELECT id_fam_motor, dsc_fam_motor 'Familia Motor' FROM Familiamotor
WHERE dsc_fam_motor LIKE @dsc_fam_motor + '%'
AND flg_ativo = 1