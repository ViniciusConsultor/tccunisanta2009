USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_pecaestoqueparampeca','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_pecaestoqueparampeca;
GO
CREATE PROCEDURE sp_busca_pecaestoqueparampeca
@id_peca INT
AS
SELECT id_peca, id_estoq, qtd_peca FROM pecaestoque
WHERE flg_ativo = 1
	AND id_peca = @id_peca

-- exec sp_busca_pecaestoqueparampeca 1
