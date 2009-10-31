USE Megatechdatabase
IF OBJECT_ID('sp_insert_tipomotor', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_tipomotor;
GO

CREATE PROCEDURE sp_insert_tipomotor
@id_tipo_motor_real    VARCHAR(20),
@dsc_tipo_motor        VARCHAR(500),
@flg_ativo             BIT
AS

BEGIN TRY
--Validações na tabela tipomotor
IF(@dsc_tipo_motor='')
   RAISERROR('Informe o nome do tipo do motor!',16,1)
ELSE IF(@id_tipo_motor_real='')
   RAISERROR('Informe o codigo do tipo do motor!',16,1)
ELSE

BEGIN
--Insert na tabela tipomotor
INSERT INTO TIPOMOTOR(id_tipo_motor_real, dsc_tipo_motor, flg_ativo)
VALUES (@id_tipo_motor_real, @dsc_tipo_motor, @flg_ativo)
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