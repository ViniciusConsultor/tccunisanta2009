USE Megatechdatabase
GO

IF OBJECT_ID('sp_busca_motorFornecedor','p') IS NOT NULL
		DROP PROCEDURE sp_busca_motorFornecedor;
GO

CREATE PROCEDURE sp_busca_motorFornecedor
@id_motor INT
AS
SELECT f.id_forn, f.nom, f.nom_pais
FROM Fornecedor f
INNER JOIN Motorfornecedor mf
ON f.id_forn = mf.id_forn
WHERE mf.id_motor = @id_motor
AND mf.flg_ativo = 1