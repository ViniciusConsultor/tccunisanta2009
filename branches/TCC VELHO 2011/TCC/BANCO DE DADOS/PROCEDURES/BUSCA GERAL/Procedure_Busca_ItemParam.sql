 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_item_param', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_item_param;
 GO
 
 CREATE PROCEDURE sp_busca_item_param
 @nom VARCHAR(20)
 AS
 SELECT id_item, nom as 'Item' FROM Item
 WHERE nom LIKE '%' + @nom + '%'
 AND flg_ativo = 1
