USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_motorestoqueparammotor','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_motorestoqueparammotor;
GO
CREATE PROCEDURE sp_busca_motorestoqueparammotor
@id_motor INT
AS
SELECT id_motor, id_estoq, qtd FROM motorestoque
WHERE flg_ativo = 1
	AND id_motor = @id_motor
