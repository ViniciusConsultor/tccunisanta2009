USE Megatechdatabase
IF OBJECT_ID('sp_insert_comprapeca', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_comprapeca;
GO

CREATE PROCEDURE sp_insert_comprapeca
@id_peca         INT,
@ultimo_preco    INT

AS 
BEGIN TRY
--Valida��es na tabela comprapeca
IF(@id_peca='')
   RAISERROR('Informe o c�digo da pe�a!',16,1)
ELSE IF(@ultimo_preco='')
   RAISERROR('Informe o preco da pe�a!',16,1)
ELSE

BEGIN
--Insert na tabela comprapeca
INSERT INTO comprapeca(id_peca, ultimo_preco)
VALUES(@id_peca, @ultimo_preco)
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