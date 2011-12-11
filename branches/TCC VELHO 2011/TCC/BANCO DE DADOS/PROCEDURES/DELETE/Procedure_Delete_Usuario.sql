USE Megatechdatabase
IF OBJECT_ID('sp_delete_usuario', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_usuario;
GO

CREATE PROCEDURE sp_delete_usuario
@id_usu	INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from usuario where id_usu=@id_usu)
BEGIN
  --deleta logicamente dependencias existentes
  IF EXISTS(select 1 from colaborador where id_usu=@id_usu)
	BEGIN
		UPDATE colaborador SET flg_ativo = 0
		WHERE id_usu=@id_usu
	END
--realiza a exclusao logicamente
UPDATE usuario SET flg_ativo = 0
WHERE id_usu=@id_usu

END
ELSE
--retorna erro se n�o houver o codigo
RAISERROR('Usuario inexistente!',16,1)
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