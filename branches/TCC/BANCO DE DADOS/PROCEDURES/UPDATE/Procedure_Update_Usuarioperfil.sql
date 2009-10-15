USE Megatechdatabase
IF OBJECT_ID('sp_update_usuarioperfil', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_usuarioperfil;
GO

CREATE PROCEDURE sp_update_usuarioperfil
@id_usu                INT,
@id_perfil             INT,
@dat_trans             DATETIME,
@flg_ativo             BIT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Usuarioperfil where id_usu = @id_usu AND id_perfil = @id_perfil)
BEGIN
--Validações para a tabela Usuarioperfil

--Update na tabela Usuarioperfil
UPDATE Usuarioperfil SET

dat_trans              = @dat_trans,
flg_ativo              = @flg_ativo

WHERE id_usu = @id_usu AND id_perfil = @id_perfil

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Perfil inexistente para este usuario!',16,1)

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