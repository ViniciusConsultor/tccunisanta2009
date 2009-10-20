USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_tipoProduto_param','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_tipoProduto_param;
GO
CREATE PROCEDURE sp_busca_tipoProduto_param
@nom VARCHAR(100)
AS
SELECT id_tipo_prod, nom as 'Tipo Produto' FROM Tipoproduto
WHERE nom LIKE @nom + '%'