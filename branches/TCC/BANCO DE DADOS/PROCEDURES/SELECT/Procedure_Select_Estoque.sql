USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_estoque','p') IS NOT NULL
		DROP PROCEDURE sp_select_estoque;
GO

CREATE PROCEDURE sp_select_estoque
@id_estoq INT
AS
SELECT id_estoq, dsc_estoq, dat_alt, id_depto, flag_negativo, flg_ativo
FROM Estoque
WHERE id_estoq = @id_estoq
AND flg_ativo = 1