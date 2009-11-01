USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_fornecedordepto','p') IS NOT NULL
		DROP PROCEDURE sp_select_fornecedordepto;
GO

CREATE PROCEDURE sp_select_fornecedordepto
@id_depto INT,
@id_forn INT
AS
SELECT id_depto, id_forn, dat_alt, flg_ativo
FROM Fornecedordepto
WHERE id_forn = @id_forn and id_depto = @id_depto
AND flg_ativo = 1