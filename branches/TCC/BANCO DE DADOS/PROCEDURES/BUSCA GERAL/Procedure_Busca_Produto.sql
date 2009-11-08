 USE Megatechdatabase
 go

 IF OBJECT_ID('sp_busca_produto', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_produto;
 GO

 CREATE PROCEDURE sp_busca_produto
 AS
 SELECT id_prdto, dsc_prdto, 0 as 'Qtd' FROM Produto p