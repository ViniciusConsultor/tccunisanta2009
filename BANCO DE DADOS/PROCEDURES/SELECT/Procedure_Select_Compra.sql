USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_compra','p') IS NOT NULL
		DROP PROCEDURE sp_select_compra;
GO

CREATE PROCEDURE sp_select_compra
@id_compra INT
AS
SELECT id_depto, id_compra, dat, obs, id_forn, id_motor, qtd, valor, nota_fisc, id_tipo_produto, id_peca
FROM Compra
WHERE id_compra = @id_compra