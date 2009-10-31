USE Megatechdatabase
IF OBJECT_ID('sp_insert_numeromotor', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_numeromotor;
GO

CREATE PROCEDURE sp_insert_numeromotor
@id_num_motor_real VARCHAR(20),
@dsc_num_motor   VARCHAR(500),
@flg_ativo       BIT
AS

BEGIN TRY
--Validações na tabela numeromotor
IF(@id_num_motor_real='')
   RAISERROR('Informe o Número do motor!',16,1)      
ELSE IF(@dsc_num_motor='')
   RAISERROR('Informe a descricao para numero do motor!',16,1)      
ELSE

BEGIN
--Insert na tabela numeromotor
INSERT INTO Numeromotor(id_num_motor_real, dsc_num_motor, flg_ativo)
VALUES (@id_num_motor_real, @dsc_num_motor, @flg_ativo)
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