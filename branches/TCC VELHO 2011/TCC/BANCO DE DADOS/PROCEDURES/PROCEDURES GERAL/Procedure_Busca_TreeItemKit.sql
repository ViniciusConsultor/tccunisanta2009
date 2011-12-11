USE Megatechdatabase
GO

IF OBJECT_ID('sp_busca_tree_itemkit','p') IS NOT NULL
		DROP PROCEDURE sp_busca_tree_itemkit;
GO

CREATE PROCEDURE sp_busca_tree_itemkit
@id_kit INT
AS
SELECT ik.id_item, ik.id_kit, ik.dat_alt, ik.qtd_item, ik.flg_ativo, i.id_item_real
FROM itemkit ik
INNER JOIN Item i
ON ik.id_item = i.id_item
WHERE id_kit = @id_kit
AND ik.flg_ativo = 1

-- exec sp_busca_tree_itemkit 3