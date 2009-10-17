USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_fornecedor_param','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_fornecedor_param;
GO
CREATE PROCEDURE sp_busca_fornecedor_param
@nomeFornecedor VARCHAR(100)
AS
<<<<<<< .mine
SELECT id_forn, nom 'Fornecedor' 
=======
SELECT id_fornecedor, nom_fornecedor as 'Nome do fornecedor'
>>>>>>> .r88
FROM fornecedor
WHERE nom LIKE @nomeFornecedor  + '%'