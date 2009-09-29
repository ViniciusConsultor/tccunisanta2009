USE Megatechdatabase
IF OBJECT_ID('sp_busca_maxEstoque', 'P')IS NOT NULL
	DROP PROCEDURE sp_busca_maxEstoque;
GO

CREATE PROCEDURE [dbo].[sp_busca_maxEstoque]
AS
SELECT MAX(id_estoque) as id_estoque
FROM Estoque
