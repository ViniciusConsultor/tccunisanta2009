USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_familiaMotor_param_nome','p') IS NOT NULL
		DROP PROCEDURE sp_busca_familiaMotor_param_nome;
GO
CREATE PROCEDURE sp_busca_familiaMotor_param_nome
@dsc_fam_motor VARCHAR(500)
AS 
SELECT id_fam_motor as 'Id', id_fam_motor_real 'Codigo', dsc_fam_motor 'Nome', 0 as 'Qtd' FROM Familiamotor
WHERE dsc_fam_motor LIKE '%' + @dsc_fam_motor + '%'
AND flg_ativo = 1
