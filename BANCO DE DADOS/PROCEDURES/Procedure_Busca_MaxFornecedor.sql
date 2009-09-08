USE Megatechdatabase
go

CREATE PROCEDURE sp_busca_maxFornecedor
AS
SELECT MAX(id_fornecedor) as id_fornecedor
FROM Fornecedor