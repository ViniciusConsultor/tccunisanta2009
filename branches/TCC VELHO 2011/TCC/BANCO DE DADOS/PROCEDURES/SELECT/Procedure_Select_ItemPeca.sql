USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_itempeca','p') IS NOT NULL
		DROP PROCEDURE sp_select_itempeca;
GO

CREATE PROCEDURE sp_select_itempeca
@id_item INT,
@id_peca INT
AS
SELECT id_item, id_peca, dat_alt, flg_ativo
FROM Itempeca
WHERE id_item = @id_item and id_peca = @id_peca
AND flg_ativo = 1