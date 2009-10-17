USE Megatechdatabase
IF OBJECT_ID('sp_update_comprapeca', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_comprapeca;
GO

CREATE PROCEDURE sp_update_comprapeca
@id_peca               VARCHAR(20),
@ultim_preco          INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Comprapeca where id_peca=@id_peca)
BEGIN
--Validações para a tabela comprapeca

--Update na tabela comprapeca
UPDATE Comprapeca SET

id_peca               = @id_peca, 
ultim_preco          = @ultim_preco

WHERE id_peca = @id_peca

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Peca inexistente nesta compra!',16,1)

END TRY

BEGIN CATCH
DECLARE @ErrorMessage NVARCHAR(4000);
DECLARE @ErrorSeverity INT;
DECLARE @ErrorState INT;
SELECT
@ErrorMessage=ERROR_MESSAGE(),
@ErrorSeverity=ERROR_SEVERITY(),
@ErrorState=ERROR_STATE();
--Use RAISERROR inside the CATCH block to return error
--information about the original error that caused
--execution to jump to the CATCH block.
RAISERROR(
@ErrorMessage, --Message text
@ErrorSeverity, --Severity
@ErrorState --State
);
END CATCH;