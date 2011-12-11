 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_item_param_nome', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_item_param_nome;
 GO
 
 CREATE PROCEDURE sp_busca_item_param_nome
@nom VARCHAR(50)
 AS
 SELECT id_item, id_item_real as 'Codigo', nom as 'Item', 0 as 'qtd' FROM Item
WHERE nom LIKE '%' + @nom + '%'
AND flg_ativo = 1