USE Megatechdatabase

CREATE PROCEDURE sp_insert_usuario
@id_usu INT,
@login VARCHAR(20),
@senha VARCHAR(15),
@obs_usu VARCHAR(100),
@flg_ativo BIT
AS
BEGIN TRY
	IF (@login = '')
	BEGIN
		RAISERROR ('Mensagem', 16, 1)
	END
	ELSE
	BEGIN
		INSERT INTO 
		Usuario (id_usu, login, senha, obs_usu, flg_ativo)
		VALUES
		(@id_usu, @login, @senha, @obs_usu, @flg_ativo)
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

    -- Use RAISERROR inside the CATCH block to return error
    -- information about the original error that caused
    -- execution to jump to the CATCH block.
    RAISERROR (@ErrorMessage, -- Message text.
               @ErrorSeverity, -- Severity.
               @ErrorState -- State.
               );
END CATCH;