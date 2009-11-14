USE Megatechdatabase
GO

IF OBJECT_ID('sp_busca_tree_vendaproduto','p') IS NOT NULL
		DROP PROCEDURE sp_busca_tree_vendaproduto;
GO

CREATE PROCEDURE sp_busca_tree_vendaproduto
@id_venda INT
AS
SELECT id_venda, flg_ativo, dat_alt, qtd, id_prdto
FROM Vendaproduto
WHERE id_venda = @id_venda
AND flg_ativo = 1