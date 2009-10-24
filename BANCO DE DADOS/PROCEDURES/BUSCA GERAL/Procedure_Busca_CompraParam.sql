USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_compra_param','p') IS NOT NULL
		DROP PROCEDURE sp_busca_compra_param;
GO
CREATE PROCEDURE sp_busca_compra_param
@obs VARCHAR(20)
AS 
SELECT id_compra, obs 'Obs Compra', dat 'Data Compra' FROM Compra
WHERE obs LIKE @obs + '%'