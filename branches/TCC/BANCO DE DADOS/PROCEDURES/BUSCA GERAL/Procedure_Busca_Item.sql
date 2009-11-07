 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_item', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_item;
 GO
 
 CREATE PROCEDURE sp_busca_item
 AS
 SELECT id_item, id_item_real as 'Codigo', nom as 'Item', 0 as 'qtd' FROM Item
 WHERE flg_ativo = 1