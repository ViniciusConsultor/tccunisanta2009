USE Megatechdatabase
IF OBJECT_ID('sp_delete_fornecedor', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_fornecedor;
GO

CREATE PROCEDURE sp_delete_fornecedor
@id_fornecedor	INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from fornecedor where id_fornecedor=@id_fornecedor)
BEGIN
  --deleta logicamente dependencias existentes
  IF EXISTS(select 1 from Fornecedordepto where id_fornecedor=@id_fornecedor)
	BEGIN
		UPDATE Fornecedordepto SET flg_ativo = 0
		WHERE id_fornecedor=@id_fornecedor
	END
  IF EXISTS(select 1 from Pecafornecedor where id_fornecedor=@id_fornecedor)
	BEGIN
		UPDATE Pecafornecedor SET flg_ativo = 0
		WHERE id_fornecedor=@id_fornecedor
	END  
--realiza a exclusao logicamente
UPDATE Fornecedor SET flg_ativo = 0
WHERE id_fornecedor = @id_fornecedor

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Fornecedor inexistente!',16,1)
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