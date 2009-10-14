USE Megatechdatabase
IF OBJECT_ID('sp_insert_menusubmenu', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_menusubmenu;
GO

CREATE PROCEDURE sp_insert_menusubmenu
@id_menu        INT,
@id_sub         INT,
@dat_trans      DATETIME,
@flg_ativo      BIT
AS

BEGIN TRY
--Validações na tabela menusubmenu
IF(@id_menu='')
   RAISERROR('Informe o codigo do menu!',16,1)   
ELSE IF(@id_sub='')
   RAISERROR('Informe o codigo do submenu!',16,1)   
ELSE

BEGIN
--Insert na tabela menusubmenu
INSERT INTO Menusubmenu(id_menu, id_sub, dat_trans, flg_ativo)
VALUES (@id_menu, @id_sub, @dat_trans, @flg_ativo)
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