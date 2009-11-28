USE Megatechdatabase
GO

IF OBJECT_ID('sp_deleta_pecaFornecedor1','p') IS NOT NULL
		DROP PROCEDURE sp_deleta_pecaFornecedor1;
GO

CREATE PROCEDURE sp_deleta_pecaFornecedor1
@id_peca INT
AS
DELETE Pecafornecedor WHERE id_peca = @id_peca