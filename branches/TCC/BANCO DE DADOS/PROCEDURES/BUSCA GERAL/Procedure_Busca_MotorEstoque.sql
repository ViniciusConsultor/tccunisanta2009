USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_motorestoque','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_motorestoque;
GO
CREATE PROCEDURE sp_busca_motorestoque
AS
SELECT id_motor, id_estoq, qtd FROM motorestoque
WHERE flg_ativo = 1