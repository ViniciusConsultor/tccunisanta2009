USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_itemReal', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_itemReal; 
GO 

CREATE PROCEDURE sp_existe_itemReal
@id_item_real VARCHAR(25)
AS

SELECT COUNT(id_item_real) as flg_existe
FROM Item
WHERE id_item_real LIKE @id_item_real
AND flg_ativo = 1