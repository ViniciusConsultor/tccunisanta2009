USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_familiaMotor_param_codigo','p') IS NOT NULL
		DROP PROCEDURE sp_busca_familiaMotor_param_codigo;
GO
CREATE PROCEDURE sp_busca_familiaMotor_param_codigo
@id_fam_motor_real VARCHAR(25)
AS 
SELECT id_fam_motor as 'Id', id_fam_motor_real 'Codigo', dsc_fam_motor 'Nome', 0 as 'Qtd' FROM Familiamotor
WHERE id_fam_motor_real LIKE '%' + @id_fam_motor_real + '%'
AND flg_ativo = 1
