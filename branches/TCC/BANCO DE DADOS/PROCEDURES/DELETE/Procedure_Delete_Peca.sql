USE Megatechdatabase
IF OBJECT_ID('sp_delete_peca', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_peca;
GO

CREATE PROCEDURE sp_delete_peca
@id_peca INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Peca where id_peca=@id_peca)
BEGIN
  --deleta logicamente dependencias existentes
  IF EXISTS(select 1 from Itempeca where id_peca=@id_peca)
	BEGIN
		UPDATE Itempeca SET flg_ativo = 0
		WHERE id_peca=@id_peca
	END	
  IF EXISTS(select 1 from Pecafornecedor where id_peca=@id_peca)
	BEGIN
		UPDATE Pecafornecedor SET flg_ativo = 0
		WHERE id_peca=@id_peca
	END
  IF EXISTS(select 1 from Usinagem where id_peca=@id_peca)
	BEGIN
		UPDATE Usinagem SET flg_status = 0
		WHERE id_peca=@id_peca
	END
--realiza a exclusao logicamente
UPDATE Peca SET flg_ativo = 0
WHERE id_peca=@id_peca

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Peca inexistente!',16,1)
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