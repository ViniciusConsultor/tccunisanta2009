USE Megatechdatabase
IF OBJECT_ID('sp_delete_item', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_item;
GO

CREATE PROCEDURE sp_delete_item
@id_item		INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from item where id_item=@id_item)
BEGIN
  --deleta logicamente dependencias existentes
  IF EXISTS(select 1 from Itemkit where id_item=@id_item)
	BEGIN
		UPDATE Itemkit SET flg_ativo = 0
		WHERE id_item=@id_item
	END
  IF EXISTS(select 1 from Itempeca where id_item=@id_item)
	BEGIN
		UPDATE Itempeca SET flg_ativo = 0
		WHERE id_item=@id_item
	END
--realiza a exclusao logicamente
UPDATE Item SET flg_ativo = 0
WHERE id_item=@id_item

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Item inexistente!',16,1)
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