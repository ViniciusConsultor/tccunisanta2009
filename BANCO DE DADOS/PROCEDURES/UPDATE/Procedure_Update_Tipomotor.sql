USE Megatechdatabase
IF OBJECT_ID('sp_update_tipomotor', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_tipomotor;
GO

CREATE PROCEDURE sp_update_tipomotor
@id_tipo_motor         VARCHAR(20),
@dsc_tipo_motor        VARCHAR(50),
@flg_ativo             BIT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from tipomotor where id_tipo_motor=@id_tipo_motor)
BEGIN
--Validações na tabela tipomotor

--Update na tabela tipomotor
UPDATE tipomotor SET

dsc_tipo_motor = @dsc_tipo_motor, 
flg_ativo      = @flg_ativo

WHERE id_tipo_motor=@id_tipo_motor

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Tipo de motor inexistente!',16,1)

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