USE Megatechdatabase
IF OBJECT_ID('sp_delete_itemkit', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_itemkit;
GO

CREATE PROCEDURE sp_delete_itemkit
@id_item	   INT,
@id_kit        INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from itemkit where id_item=@id_item and id_kit=@id_kit)
BEGIN
  --deleta logicamente dependencias existentes
  
  --realiza a exclusao logicamente
UPDATE itemkit SET flg_ativo = 0
WHERE id_item=@id_item and id_kit=@id_kit

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Item de peca inexistente!',16,1)
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