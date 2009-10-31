USE Megatechdatabase
IF OBJECT_ID('sp_update_usuario', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_usuario;
GO

CREATE PROCEDURE sp_update_usuario
@id_usu        INT,
@log_usu       VARCHAR(20),
@senha         VARCHAR(15),
@obs_usu       VARCHAR(100),
@flg_ativo     BIT,
@id_perfil     INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Usuario where id_usu=@id_usu)
BEGIN
--Validações na tabela  usuario

--Update na tabela usuario
UPDATE Usuario SET

log_usu      = @log_usu, 
senha        = @senha, 
obs_usu      = @obs_usu, 
flg_ativo    = @flg_ativo,
id_perfil    = @id_perfil

WHERE id_usu = @id_usu

END
ELSE
--retorna erro se não houver o codigo
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
