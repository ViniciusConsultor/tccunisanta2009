USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_tipodepeca','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_tipodepeca;
GO
CREATE PROCEDURE sp_busca_tipoProduto
AS
SELECT id_tipo_peca, dsc_tipo_peca as 'Tipo Pe�a' FROM Tipopeca