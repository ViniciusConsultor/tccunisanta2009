USE Megatechdatabase
IF OBJECT_ID('sp_insert_usuario', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_usuario;
GO

CREATE PROCEDURE sp_insert_usuario
@id_usu        INT,
@login         VARCHAR(20),
@senha         VARCHAR(15),
@obs_usu       VARCHAR(100),
@flg_ativo     BIT
AS

BEGIN TRY
--Valida��es na tabela  usuario
IF(@id_usu='')
  RAISERROR('Informe o c�digo do usu�rio!',16,1)
ELSE IF(@login='')
  RAISERROR('Informe o login do usu�rio!',16,1)
ELSE IF(@senha='')
  RAISERROR('Informe a senha do usu�rio!',16,1)
ELSE

BEGIN
--Insert na tabela usuario
INSERT INTO 
Usuario(id_usu, login, senha, obs_usu, flg_ativo)
VALUES(@id_usu, @login, @senha, @obs_usu, @flg_ativo)
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
