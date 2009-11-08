 USE Megatechdatabase
 go

 IF OBJECT_ID('sp_busca_produto_famliaMotor', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_produto_famliaMotor;
 GO

 CREATE PROCEDURE sp_busca_produto_famliaMotor
 AS
 SELECT id_prdto, dsc_prdto, 0 as 'Qtd' FROM Produto p
 INNER JOIN Familiamotor fm
 ON p.id_fam_motor = fm.id_fam_motor