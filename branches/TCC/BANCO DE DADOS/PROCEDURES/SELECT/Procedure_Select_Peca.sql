USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_peca','p') IS NOT NULL
		DROP PROCEDURE sp_select_peca;
GO

CREATE PROCEDURE sp_select_peca
@id_peca INT
AS
SELECT id_peca, id_peca_real, nom, dat_alt, peso, flg_ativo, dsc_peca, id_estoque, qtd_min, id_tipo_peca
FROM Peca
WHERE id_peca = @id_peca