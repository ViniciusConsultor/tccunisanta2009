 USE Megatechdatabase
 go

 IF OBJECT_ID('sp_busca_produto_famliaMotor_param_codigo', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_produto_famliaMotor_param_codigo;
 GO

 CREATE PROCEDURE sp_busca_produto_famliaMotor_param_codigo
 @id_fam_motor_real VARCHAR(25)
 AS
 SELECT id_prdto, dsc_prdto, 0 as 'Qtd' FROM Produto p
 INNER JOIN Familiamotor fm
 ON p.id_fam_motor = fm.id_fam_motor
 WHERE id_fam_motor_real LIKE '%' + @id_fam_motor_real + '%'