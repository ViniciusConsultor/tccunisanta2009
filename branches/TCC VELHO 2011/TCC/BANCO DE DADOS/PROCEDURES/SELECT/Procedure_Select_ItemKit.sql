USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_itemkit','p') IS NOT NULL
		DROP PROCEDURE sp_select_itemkit;
GO

CREATE PROCEDURE sp_select_itemkit
@id_item INT,
@id_kit INT
AS
SELECT id_item, id_kit, flg_ativo, dat_alt
FROM Itemkit
WHERE id_item = @id_item and id_kit = @id_kit
AND flg_ativo = 1