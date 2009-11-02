USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_pecaestoque','p') IS NOT NULL
		DROP PROCEDURE sp_select_pecaestoque;
GO

CREATE PROCEDURE sp_select_pecaestoque
@id_peca  INT,
@id_estoq INT
AS
SELECT id_peca, id_estoq, flg_ativo, dat_alt, qtd_peca
FROM PecaEstoque
WHERE id_peca = @id_peca and id_estoq = @id_estoq
AND flg_ativo = 1