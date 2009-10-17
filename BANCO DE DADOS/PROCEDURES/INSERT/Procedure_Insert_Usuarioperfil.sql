USE Megatechdatabase
IF OBJECT_ID('sp_insert_usuarioperfil', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_usuarioperfil;
GO

CREATE PROCEDURE sp_insert_usuarioperfil
@id_usu        INT,
@id_perfil     INT,
@dat_alt     DATETIME,
@flg_ativo     BIT
AS

BEGIN TRY
--Validações na tabela  usuarioperfil
IF(@id_usu='')
  RAISERROR('Informe o código do usuário!',16,1)
ELSE IF(@id_perfil='')
  RAISERROR('Informe o código do perfil!',16,1)
ELSE

BEGIN
--Insert na tabela usuarioperfil
INSERT INTO Usuarioperfil(id_usu, id_perfil, dat_alt, flg_ativo)
VALUES(@id_usu, @id_perfil, @dat_alt, @flg_ativo)
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
