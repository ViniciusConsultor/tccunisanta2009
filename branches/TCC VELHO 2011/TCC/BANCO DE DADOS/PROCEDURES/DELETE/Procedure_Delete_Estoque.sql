USE Megatechdatabase
IF OBJECT_ID('sp_delete_estoque', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_estoque;
GO

CREATE PROCEDURE sp_delete_estoque
@id_estoq	INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from estoque where id_estoq=@id_estoq)
BEGIN
  --deleta logicamente dependencias existentes
  IF EXISTS(select 1 from Pecaestoque where id_estoq=@id_estoq)
	BEGIN
		UPDATE pecaestoque SET flg_ativo=0
	END	

--realiza a exclusao logicamente
UPDATE estoque SET flg_ativo = 0
WHERE id_estoq = @id_estoq

END
ELSE
--retorna erro se n�o houver o codigo
RAISERROR('Estoque inexistente!',16,1)
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