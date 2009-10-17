USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_estoque','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_estoque;
GO
CREATE PROCEDURE sp_busca_estoque
AS
<<<<<<< .mine
SELECT id_estoq, dsc_estoq 'Estoque' FROM Estoque=======
SELECT id_estoque, nom_estoque AS 'Nome do estoque'
FROM Estoque>>>>>>> .r88
