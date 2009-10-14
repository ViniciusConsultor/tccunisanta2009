USE Megatechdatabase
IF OBJECT_ID('sp_insert_perfilmenu', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_perfilmenu;
GO

CREATE PROCEDURE sp_insert_perfilmenu
@id_perfil     INT,
@id_menu       INT,
@dat_trans  DATETIME,
@flg_ativo     BIT
AS

BEGIN TRY
--Validações na tabela perfilmenu
IF(@id_perfil='')
   RAISERROR('Informe o codigo do perfil!',16,1)
ELSE IF(@id_menu='')
   RAISERROR('Informe o codigo do menu!',16,1)
ELSE

BEGIN
--Insert na tabela perfilmenu
INSERT INTO Perfilmenu(id_perfil, id_menu, dat_trans, flg_ativo)
VALUES(@id_perfil, @id_menu, @dat_trans, @flg_ativo)
END
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