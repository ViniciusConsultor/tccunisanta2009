USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_item', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_item; 
GO 

CREATE PROCEDURE sp_existe_item
@id_item_real VARCHAR(25)
AS

SELECT COUNT(id_item_real) as flg_existe
FROM Item
WHERE id_item_real LIKE @id_item_real