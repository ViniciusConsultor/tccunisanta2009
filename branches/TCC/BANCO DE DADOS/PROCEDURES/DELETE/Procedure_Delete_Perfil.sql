USE Megatechdatabase
IF OBJECT_ID('sp_delete_perfil', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_perfil;
GO

CREATE PROCEDURE sp_delete_perfil
@id_perfil INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Perfil where id_perfil=@id_perfil)
BEGIN
  --deleta logicamente dependencias existentes
  IF EXISTS(select 1 from Perfilmenu where id_perfil=@id_perfil)
	BEGIN
		UPDATE Perfilmenu SET flg_ativo = 0
		WHERE id_perfil=@id_perfil
	END	
  IF EXISTS(select 1 from Usuarioperfil where id_perfil=@id_perfil)
	BEGIN
		UPDATE Usuarioperfil SET flg_ativo = 0
		WHERE id_perfil=@id_perfil
	END
--realiza a exclusao logicamente
UPDATE Perfil SET flg_ativo = 0
WHERE id_perfil=@id_perfil

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Perfil inexistente!',16,1)
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