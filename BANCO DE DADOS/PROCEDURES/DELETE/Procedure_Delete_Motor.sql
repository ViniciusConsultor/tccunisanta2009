USE Megatechdatabase
IF OBJECT_ID('sp_delete_motor', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_motor;
GO

CREATE PROCEDURE sp_delete_motor
@id_motor_compra	INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from motor where id_motor_compra=@id_motor_compra)
BEGIN
  --deleta logicamente dependencias existentes
  IF EXISTS(select 1 from familiamotor where id_motor_compra=@id_motor_compra)
	BEGIN
		UPDATE familiamotor SET flg_ativo = 0
		WHERE id_motor_compra=@id_motor_compra
	END	
--realiza a exclusao logicamente
UPDATE motor SET flg_ativo = 0
WHERE id_motor_compra=@id_motor_compra

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Motor inexistente!',16,1)
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