USE Megatechdatabase
IF OBJECT_ID('sp_insert_Tipodepeca', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_Tipodepeca;
GO

CREATE PROCEDURE sp_insert_Tipodepeca
@id_tipo_peca    INT,
@dsc_tipo_peca   VARCHAR(500),
@flg_ativo       BIT
AS

BEGIN TRY
--Validações na tabela tipopeça
IF(@id_tipo_peca='')
   RAISERROR('Informe o codigo do tipo da peça!',16,1)   
ELSE

BEGIN
--Insert na tabela tipopeça
INSERT INTO Tipodepeca(id_tipo_peca, dsc_tipo_peca, flg_ativo)
VALUES (@id_tipo_peca, @dsc_tipo_peca, @flg_ativo)
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