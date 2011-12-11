 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_item_param_codigo', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_item_param_codigo;
 GO
 
 CREATE PROCEDURE sp_busca_item_param_codigo
@id_item_real VARCHAR(25)
 AS
 SELECT id_item, id_item_real as 'Codigo', nom as 'Item', 0 as 'qtd' FROM Item
 WHERE id_item_real LIKE '%' + @id_item_real + '%'
 AND flg_ativo = 1