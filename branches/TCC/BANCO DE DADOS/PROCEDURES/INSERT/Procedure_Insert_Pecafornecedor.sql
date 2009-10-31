USE Megatechdatabase
IF OBJECT_ID('sp_insert_pecafornecedor', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_pecafornecedor;
GO

CREATE PROCEDURE sp_insert_pecafornecedor
@id_peca               INT,
@id_forn			   INT,
@dat_inc               DATETIME,
@flg_ativo             BIT
AS

BEGIN TRY
--Validações na tabela pecaforncedor
IF(@id_peca='')
   RAISERROR('Informe o codigo da peça!',16,1)   
ELSE IF(@id_forn='')
   RAISERROR('Informe o do codigo do fornecedor!',16,1)   
ELSE

BEGIN
--Insert na tabela pecafornecedor
INSERT INTO PECAFORNECEDOR(id_peca, id_forn, dat_inc, flg_ativo)
VALUES (@id_peca, @id_forn, @dat_inc, @flg_ativo)
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