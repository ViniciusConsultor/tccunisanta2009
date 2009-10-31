USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_pecafornecedor','p') IS NOT NULL
		DROP PROCEDURE sp_select_pecafornecedor;
GO

CREATE PROCEDURE sp_select_pecafornecedor
@id_peca INT,
@id_forn INT
AS
SELECT id_peca, id_forn, dat_inc
FROM Pecafornecedor
WHERE id_peca = @id_peca and id_forn = @id_forn
AND flg_ativo = 1