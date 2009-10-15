USE Megatechdatabase
IF OBJECT_ID('sp_delete_pecafornecedor', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_pecafornecedor;
GO

CREATE PROCEDURE sp_delete_pecafornecedor
@id_peca    	INT,
@id_fornecedor  INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Pecafornecedor where id_fornecedor=@id_fornecedor and id_peca=@id_peca)
BEGIN
  --deleta logicamente dependencias existentes
    
--realiza a exclusao logicamente
UPDATE Pecafornecedor SET flg_ativo = 0
WHERE id_fornecedor = @id_fornecedor and id_peca=@id_peca

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Peca nao existente para este fornecedor!',16,1)
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