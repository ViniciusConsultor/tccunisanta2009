USE Megatechdatabase
IF OBJECT_ID('sp_delete_comprapeca', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_comprapeca;
GO

CREATE PROCEDURE sp_delete_comprapeca
@id_peca   INT,
@id_compra INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from comprapeca where id_peca=@id_peca and id_compra=@id_compra)
BEGIN
  --deleta dependencias existentes
  
  --realiza a exclusao  
  DELETE comprapeca WHERE id_peca = @id_peca and id_compra=@id_compra
END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Item de Compra inexistente!',16,1)
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