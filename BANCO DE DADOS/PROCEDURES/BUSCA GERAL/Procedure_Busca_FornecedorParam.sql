USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_fornecedor_param','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_fornecedor_param;
GO
CREATE PROCEDURE sp_busca_fornecedor_param
@nomeFornecedor VARCHAR(100)
AS
SELECT id_forn, nom 'Fornecedor' 
FROM fornecedor
WHERE nom LIKE @nomeFornecedor  + '%'
AND flg_ativo = 1