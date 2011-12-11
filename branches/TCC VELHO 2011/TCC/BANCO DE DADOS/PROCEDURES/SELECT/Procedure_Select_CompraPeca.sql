USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_comprapeca','p') IS NOT NULL
		DROP PROCEDURE sp_select_comprapeca;
GO

CREATE PROCEDURE sp_select_comprapeca
@id_peca INT
AS
SELECT id_peca, ultim_preco, id_compra
FROM Comprapeca
WHERE id_peca = @id_peca