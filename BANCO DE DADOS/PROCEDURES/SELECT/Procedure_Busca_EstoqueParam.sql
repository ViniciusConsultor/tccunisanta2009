USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_estoque_param','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_estoque_param;
GO
CREATE PROCEDURE sp_busca_estoque_param
@nom_estoque VARCHAR(500)
AS
SELECT id_estoque, nom_estoque 
FROM Estoque
WHERE nom_estoque LIKE @nom_estoque  + '%'