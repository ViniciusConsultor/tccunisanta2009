USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_compra','p') IS NOT NULL
		DROP PROCEDURE sp_busca_compra;
GO
CREATE PROCEDURE sp_busca_compra
AS 
SELECT id_compra, obs, dat FROM Compra