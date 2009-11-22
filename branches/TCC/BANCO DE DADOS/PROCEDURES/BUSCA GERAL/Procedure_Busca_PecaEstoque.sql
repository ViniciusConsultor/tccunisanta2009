USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_pecaestoque','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_pecaestoque;
GO
CREATE PROCEDURE sp_busca_pecaestoque
AS
SELECT id_peca, id_estoq, qtd_peca FROM pecaestoque
WHERE flg_ativo = 1