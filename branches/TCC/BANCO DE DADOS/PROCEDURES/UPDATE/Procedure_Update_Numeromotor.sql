USE Megatechdatabase
IF OBJECT_ID('sp_update_numeromotor', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_numeromotor;
GO

CREATE PROCEDURE sp_update_numeromotor
@id_num_motor    INT,
@dsc_num_motor  VARCHAR(50),
@flg_ativo       BIT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Numeromotor where id_num_motor=@id_num_motor)
BEGIN
--Validações na tabela numeromotor

--Update na tabela numeromotor
UPDATE Numeromotor SET

dsc_num_motor  = @dsc_num_motor, 
flg_ativo      = @flg_ativo

WHERE id_num_motor = @id_num_motor

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Numero de motor inexistente!',16,1)

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