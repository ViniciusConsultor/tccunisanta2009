USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_fornecedor','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_fornecedor;
GO
CREATE PROCEDURE sp_busca_fornecedor
AS
SELECT id_forn, nom 'Fornecedor' FROM fornecedor
WHERE flg_ativo = 1