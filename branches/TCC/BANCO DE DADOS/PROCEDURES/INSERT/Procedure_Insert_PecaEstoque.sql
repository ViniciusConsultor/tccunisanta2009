USE Megatechdatabase
IF OBJECT_ID('sp_insert_pecaestoque', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_pecaestoque;
GO

CREATE PROCEDURE sp_insert_pecaestoque
@id_estoq     INT,
@id_peca	  INT,
@qtd_peca	  INT,
@dat_alt      DATETIME,
@flg_ativo    BIT

AS 
BEGIN TRY
--Validações na tabela pecaestoque
IF(@id_peca='')
   RAISERROR('Informe o código da peça relacionada ao estoque!',16,1)
ELSE IF(@id_estoq='')
   RAISERROR('Informe o código do estoque!',16,1)
ELSE
BEGIN
--Insert na tabela estoque
INSERT INTO PECAESTOQUE(id_peca, id_estoq, flg_ativo, dat_alt, qtd_peca)
VALUES(@id_peca, @id_estoq, @flg_ativo, @dat_alt, @qtd_peca)
END
END TRY

BEGIN CATCH
DECLARE @ErrorMessage NVARCHAR(4000);
DECLARE @ErrorSeverity INT;
DECLARE @ErrorState INT;

SELECT
@ErrorMessage = ERROR_MESSAGE(),
@ErrorSeverity = ERROR_SEVERITY(),
@ErrorState = ERROR_STATE();
--Use RAISERROR inside the CATCH block to return error
--information about the original error that caused
--execution to jump to the CATCH block.
RAISERROR(
@ErrorMessage, --Message text
@ErrorSeverity, --Severity
@ErrorState --State
);
END CATCH;