USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_estoque','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_estoque;
GO
CREATE PROCEDURE sp_busca_estoque
AS
SELECT id_estoque, nom_estoque FROM Estoque