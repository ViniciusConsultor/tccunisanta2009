 USE Megatechdatabase
 go

 IF OBJECT_ID('sp_busca_produto_kit_param_nome', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_produto_kit_param_nome;
 GO

 CREATE PROCEDURE sp_busca_produto_kit_param_nome
 @nom VARCHAR(25)
 AS
 SELECT id_prdto, dsc_prdto, 0 as 'Qtd' FROM Produto p
 INNER JOIN Kitgrupopeca kgp
 ON p.id_kit = kgp.id_kit
 WHERE nom LIKE '%' + @nom + '%'