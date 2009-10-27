 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_itemPeca_param', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_itemPeca_param;
 GO
 
 CREATE PROCEDURE sp_busca_itemPeca_param
 @nom VARCHAR(20)
 AS
 SELECT id_item_peca, nom as 'Item Peça' FROM Itempeca
 WHERE nom LIKE '%' + @nom + '%'
 AND flg_ativo = 1
