USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_item','p') IS NOT NULL
		DROP PROCEDURE sp_select_item;
GO

CREATE PROCEDURE sp_select_item
@id_item INT
AS
SELECT id_item, id_item_real, nom, dat_alt, flg_ativo
FROM Item
WHERE id_item = @id_item
AND flg_ativo = 1