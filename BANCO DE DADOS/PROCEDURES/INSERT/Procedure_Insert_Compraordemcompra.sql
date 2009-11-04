USE Megatechdatabase
IF OBJECT_ID('sp_insert_compraordemcompra', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_compraordemcompra;
GO

CREATE PROCEDURE sp_insert_compraordemcompra
@id_compra			INT,
@id_ordem_compra	INT,
@qtd				INT,
@dat_alt			DATETIME,
@flg_ativo			BIT
AS

BEGIN TRY
--Validações na tabela compraordemcompra
IF(@id_compra='')
   RAISERROR('Informe o codigo do compra!',16,1)   
ELSE IF(@id_ordem_compra='')
   RAISERROR('Informe o codigo do ordem de compra!',16,1)   
ELSE IF(@qtd='')
   RAISERROR('Informe a quantidade da ordem!',16,1)
ELSE

BEGIN
--Insert na tabela compraordemcompra
INSERT INTO compraordemcompra(id_compra, id_ordem_compra, qtd, dat_alt, flg_ativo)
VALUES (@id_compra, @id_ordem_compra, @qtd, @dat_alt, @flg_ativo)
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