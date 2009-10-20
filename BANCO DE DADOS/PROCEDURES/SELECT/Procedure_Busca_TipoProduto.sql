USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_tipoProduto','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_tipoProduto;
GO
CREATE PROCEDURE sp_busca_tipoProduto
AS
SELECT id_tipo_prod, nom as 'Tipo Produto' FROM Tipoproduto