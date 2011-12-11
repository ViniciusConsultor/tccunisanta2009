 USE Megatechdatabase
 go

 IF OBJECT_ID('sp_busca_produto_famliaMotor_param_nome', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_produto_famliaMotor_param_nome;
 GO

 CREATE PROCEDURE sp_busca_produto_famliaMotor_param_nome
 @dsc_fam_motor VARCHAR(25)
 AS
 SELECT id_prdto, dsc_prdto, 0 as 'Qtd' FROM Produto p
 INNER JOIN Familiamotor fm
 ON p.id_fam_motor = fm.id_fam_motor
 WHERE dsc_fam_motor LIKE '%' + @dsc_fam_motor + '%'