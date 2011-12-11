USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_estoque','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_estoque;
GO
CREATE PROCEDURE sp_busca_estoque
AS
SELECT id_estoq, dsc_estoq 'Estoque' , 0 as 'qtd_peca' FROM Estoque
WHERE flg_ativo = 1