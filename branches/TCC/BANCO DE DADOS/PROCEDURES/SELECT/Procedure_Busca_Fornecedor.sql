USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_fornecedor','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_fornecedor;
GO
CREATE PROCEDURE sp_busca_fornecedor
AS
SELECT id_fornecedor, nom_fornecedor as 'Nome do fornecedor' FROM fornecedor