USE Megatechdatabase
GO

IF OBJECT_ID('sp_busca_pecaFornecedor','p') IS NOT NULL
		DROP PROCEDURE sp_busca_pecaFornecedor;
GO

CREATE PROCEDURE sp_busca_pecaFornecedor
@id_peca INT
AS
SELECT f.nom, f.nom_pais
FROM Fornecedor f
INNER JOIN Pecafornecedor pf
ON f.id_forn = pf.id_forn
WHERE pf.id_peca = @id_peca
AND pf.flg_ativo = 1