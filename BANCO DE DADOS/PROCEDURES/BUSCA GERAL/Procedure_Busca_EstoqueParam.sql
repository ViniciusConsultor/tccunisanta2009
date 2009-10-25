USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_estoque_param','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_estoque_param;
GO
CREATE PROCEDURE sp_busca_estoque_param
@nom_estoque VARCHAR(500)
AS
SELECT id_estoq, dsc_estoq 'Estoque' 
FROM Estoque
WHERE dsc_estoq LIKE @nom_estoque  + '%'
AND flg_ativo = 1