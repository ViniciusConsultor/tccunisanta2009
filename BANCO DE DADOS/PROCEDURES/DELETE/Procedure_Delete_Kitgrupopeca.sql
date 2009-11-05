USE Megatechdatabase
IF OBJECT_ID('sp_delete_kitgrupopeca', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_kitgrupopeca;
GO

CREATE PROCEDURE sp_delete_kitgrupopeca
@id_kit		INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Kitgrupopeca where id_kit=@id_kit)
BEGIN
  --deleta logicamente dependencias existentes
  IF EXISTS(select 1 from Itemkit where id_kit=@id_kit)
	BEGIN
		UPDATE Itemkit SET flg_ativo = 0
		WHERE id_kit=@id_kit
	END
  IF EXISTS(select 1 from Kitfamilia where id_kit=@id_kit)
	BEGIN
		UPDATE Itemkit SET flg_ativo = 0
		WHERE id_kit=@id_kit
	END
  /*IF EXISTS(select 1 from Ordemproducao where id_kit=@id_kit)
	BEGIN
		UPDATE Itemkit SET flg_ativo = 0
		WHERE id_kit=@id_kit
	END*/
--realiza a exclusao logicamente
UPDATE Kitgrupopeca SET flg_ativo = 0
WHERE id_kit=@id_kit

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Kit de pecas inexistente!',16,1)
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