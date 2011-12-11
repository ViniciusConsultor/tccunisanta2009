USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_tipoproduto','p') IS NOT NULL
		DROP PROCEDURE sp_select_tipoproduto;
GO

CREATE PROCEDURE sp_select_tipoproduto
@id_tipo_prod INT
AS
SELECT id_tipo_prod, nom, dat_alt, flg_ativo
FROM Tipoproduto
WHERE id_tipo_prod = @id_tipo_prod
AND flg_ativo = 1