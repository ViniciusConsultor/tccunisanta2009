USE Megatechdatabase
IF OBJECT_ID('sp_busca_maxFornecedor', 'P')IS NOT NULL
	DROP PROCEDURE sp_busca_maxFornecedor;
GO

CREATE PROCEDURE sp_busca_maxFornecedor
AS
SELECT MAX(id_fornecedor) as id_fornecedor
FROM Fornecedor