USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_estoque','p') IS NOT NULL
		DROP PROCEDURE sp_select_estoque;
GO

CREATE PROCEDURE sp_select_estoque
@id_estoq INT
AS
SELECT id_estoq, dsc_estoq, dat_alt, flg_ativo, id_depto
FROM Estoque
WHERE id_estoq = @id_estoq