USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_itempeca','p') IS NOT NULL
		DROP PROCEDURE sp_select_itempeca;
GO

CREATE PROCEDURE sp_select_itempeca
@id_item_peca INT,
@id_peca INT
AS
SELECT id_item_peca, id_peca, dat_alt, flg_ativo
FROM Itempeca
WHERE id_item_peca = @id_item_peca and id_peca = @id_peca
AND flg_ativo = 1