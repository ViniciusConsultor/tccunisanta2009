USE Megatechdatabase
IF OBJECT_ID('sp_insert_motor', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_motor;
GO

CREATE PROCEDURE sp_insert_motor
@id_motor    INT,
@dsc_motor   VARCHAR(100),
@flg_ativo   BIT
AS

BEGIN TRY
--Validações na tabela motor
IF(@id_motor='')
   RAISERROR('Informe o codigo do motor!',16,1)
ELSE
IF(@dsc_motor='')
   RAISERROR('Informe a descrição do motor!',16,1)

BEGIN
--Insert na tabela motor
INSERT INTO Motor(id_motor, dsc_motor, flg_ativo)
VALUES (@id_motor, @dsc_motor, @flg_ativo)
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