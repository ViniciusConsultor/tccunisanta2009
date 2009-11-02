USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_venda','p') IS NOT NULL
		DROP PROCEDURE sp_select_venda;
GO

CREATE PROCEDURE sp_select_venda
@id_venda INT
AS
SELECT id_venda, id_cli, dat_venda, qtd, valor, nota_fisc, dat_saida, id_ordem, id_tipo_prod
FROM Venda
WHERE id_venda = @id_venda