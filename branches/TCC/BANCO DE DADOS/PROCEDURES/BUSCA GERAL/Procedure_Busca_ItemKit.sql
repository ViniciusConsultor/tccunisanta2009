USE Megatechdatabase
 go

 IF OBJECT_ID('sp_busca_itemKit', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_itemKit;
 GO

 CREATE PROCEDURE sp_busca_itemKit
 AS
 SELECT id_item, id_kit FROM itemKit
 WHERE flg_ativo = 1