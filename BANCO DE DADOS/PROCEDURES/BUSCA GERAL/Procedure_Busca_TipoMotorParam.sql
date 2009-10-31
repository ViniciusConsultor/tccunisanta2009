USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_tipoMotor_param','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_tipoMotor_param;
GO
CREATE PROCEDURE sp_busca_tipoMotor_param
@dsc_tipo_motor VARCHAR(500)
AS
SELECT id_tipo_motor, dsc_tipo_motor 'Tipo Motor'
FROM Tipomotor
WHERE dsc_tipo_motor LIKE '%' + @dsc_tipo_motor  + '%'
AND flg_ativo = 1
