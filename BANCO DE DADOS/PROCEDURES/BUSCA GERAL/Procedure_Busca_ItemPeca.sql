 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_itemPeca', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_itemPeca;
 GO
 
 CREATE PROCEDURE sp_busca_itemPeca
 AS
 SELECT id_item_peca, nom as 'Item Pe�a' FROM Itempeca
 WHERE flg_ativo = 1