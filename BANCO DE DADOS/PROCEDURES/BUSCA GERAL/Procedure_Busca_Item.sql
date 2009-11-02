 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_item', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_item;
 GO
 
 CREATE PROCEDURE sp_busca_item
 AS
 SELECT id_item, nom as 'Item' FROM Item
 WHERE flg_ativo = 1