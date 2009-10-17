USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_estoque_param','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_estoque_param;
GO
CREATE PROCEDURE sp_busca_estoque_param
@nom_estoque VARCHAR(500)
AS
<<<<<<< .mine
SELECT id_estoq, dsc_estoq 'Estoque' 
=======
SELECT id_estoque, nom_estoque AS 'nome estque'
>>>>>>> .r88
FROM Estoque
WHERE dsc_estoq LIKE @nom_estoque  + '%'