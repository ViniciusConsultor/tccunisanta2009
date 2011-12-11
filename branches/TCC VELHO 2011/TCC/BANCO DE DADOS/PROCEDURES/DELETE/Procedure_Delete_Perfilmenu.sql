USE Megatechdatabase
IF OBJECT_ID('sp_delete_perfilmenu', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_perfilmenu;
GO

CREATE PROCEDURE sp_delete_perfilmenu
@id_perfil    	INT,
@id_menu        INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Perfilmenu where id_perfil=@id_perfil and id_menu=@id_menu)
BEGIN
  --deleta logicamente dependencias existentes
    
--realiza a exclusao logicamente
UPDATE Perfilmenu SET flg_ativo = 0
WHERE id_perfil = @id_perfil and id_menu=@id_menu

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Menu nao existente para este perfil!',16,1)
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