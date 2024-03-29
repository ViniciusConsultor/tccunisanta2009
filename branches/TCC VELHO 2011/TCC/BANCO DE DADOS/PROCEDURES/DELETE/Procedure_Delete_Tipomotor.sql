USE Megatechdatabase
IF OBJECT_ID('sp_delete_tipomotor', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_tipomotor;
GO

CREATE PROCEDURE sp_delete_tipomotor
@id_tipo_motor INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Tipomotor where id_tipo_motor=@id_tipo_motor)
BEGIN
  --deleta logicamente dependencias existentes
  IF EXISTS(select 1 from Familiamotor where id_tipo_motor=@id_tipo_motor)
	BEGIN
		UPDATE Familiamotor SET flg_ativo = 0
		WHERE id_tipo_motor=@id_tipo_motor
	END	
--realiza a exclusao logicamente
UPDATE Tipomotor SET flg_ativo = 0
WHERE id_tipo_motor=@id_tipo_motor

END
ELSE
--retorna erro se n�o houver o codigo
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