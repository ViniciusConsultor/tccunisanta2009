USE Megatechdatabase
GO

IF OBJECT_ID('sp_busca_tree_produto','p') IS NOT NULL
		DROP PROCEDURE sp_busca_tree_produto;
GO

CREATE PROCEDURE sp_busca_tree_produto
@id_prdto INT,
@id_venda INT
AS
SELECT p.id_prdto, p.dsc_prdto, p.id_fam_motor, p.id_kit, p.id_tipo_produto, vp.qtd
FROM Produto p
INNER JOIN Vendaproduto vp
ON p.id_prdto = vp.id_prdto
INNER JOIN Venda v
ON v.id_venda = vp.id_venda
WHERE p.id_prdto = @id_prdto
AND vp.id_venda = @id_venda
AND p.flg_ativo = 1