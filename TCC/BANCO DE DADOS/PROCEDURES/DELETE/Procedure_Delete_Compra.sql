USE Megatechdatabase
IF OBJECT_ID('sp_delete_compra', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_compra;
GO

CREATE PROCEDURE sp_delete_compra
@id_compra INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from compra where id_compra=@id_compra)
BEGIN
  --deleta dependencias existentes
  IF EXISTS(select 1 from Compraordemcompra where id_compra=@id_compra)
	BEGIN
		UPDATE Compraordemcompra SET flg_ativo=0
	END	
  --realiza a exclusao  
  DELETE compra WHERE id_compra = @id_compra
END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Compra inexistente!',16,1)
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