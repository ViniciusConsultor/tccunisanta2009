USE Megatechdatabase
IF OBJECT_ID('sp_delete_itempeca', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_itempeca;
GO

CREATE PROCEDURE sp_delete_itempeca
@id_item_peca	INT,
@id_peca        INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from itempeca where id_item_peca=@id_item_peca and id_peca=@id_peca)
BEGIN
  --deleta logicamente dependencias existentes
  IF EXISTS(select 1 from Kitgrupopeca where id_item_peca=@id_item_peca)
	BEGIN
		UPDATE Kitgrupopeca SET flg_ativo = 0
		WHERE id_item_peca=@id_item_peca
	END
--realiza a exclusao logicamente
UPDATE Itempeca SET flg_ativo = 0
WHERE id_item_peca=@id_item_peca and id_peca=@id_peca

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