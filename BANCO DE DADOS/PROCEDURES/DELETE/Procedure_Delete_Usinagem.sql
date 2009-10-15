USE Megatechdatabase
IF OBJECT_ID('sp_delete_usinagem', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_usinagem;
GO

CREATE PROCEDURE sp_delete_usinagem
@id_usinagem INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Usinagem where id_usinagem=@id_usinagem)
BEGIN
  --deleta logicamente dependencias existentes
  
--realiza a exclusao logicamente
UPDATE Usinagem SET flg_status = 0
WHERE id_usinagem=@id_usinagem

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Usinagem inexistente!',16,1)
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