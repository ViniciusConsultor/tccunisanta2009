USE Megatechdatabase
GO

IF OBJECT_ID('sp_busca_tree_itemkit','p') IS NOT NULL
		DROP PROCEDURE sp_busca_tree_itemkit;
GO

CREATE PROCEDURE sp_busca_tree_itemkit
@id_kit INT
AS
SELECT id_item, id_0kit, dat_alt, qtd_item, flg_ativo
FROM itemkit
WHERE id_kit = @id_kit
AND flg_ativo = 1

-- exec sp_busca_tree_itemkit 1