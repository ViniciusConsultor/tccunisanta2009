USE Megatechdatabase
IF OBJECT_ID('sp_update_perfilmenu', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_perfilmenu;
GO

CREATE PROCEDURE sp_update_perfilmenu
@id_perfil             INT,
@id_menu               INT,
@dat_alt             DATETIME,
@flg_ativo             BIT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Perfilmenu where id_perfil = @id_perfil AND id_menu = @id_menu)
BEGIN
--Validações para a tabela perfilmenu

--Update na tabela perfilmenu
UPDATE Perfilmenu SET

dat_alt              = @dat_alt,
flg_ativo              = @flg_ativo

WHERE id_perfil = @id_perfil AND id_menu = @id_menu

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Menu inexistente para este perfil!',16,1)

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