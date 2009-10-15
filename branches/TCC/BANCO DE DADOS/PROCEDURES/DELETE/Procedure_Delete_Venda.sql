USE Megatechdatabase
IF OBJECT_ID('sp_delete_venda', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_venda;
GO

CREATE PROCEDURE sp_delete_venda
@id_venda INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from venda where id_venda=@id_venda)
BEGIN
  --deleta dependencias existentes
  IF EXISTS(select 1 from pedidovenda where id_venda=@id_venda)
	BEGIN
		DELETE pedidovenda WHERE id_venda=@id_venda
	END
  
  --realiza a exclusao
  DELETE venda WHERE id_venda = @id_venda
END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Venda inexistente!',16,1)
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