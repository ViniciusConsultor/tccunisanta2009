USE Megatechdatabase
IF OBJECT_ID('sp_delete_kitfamilia', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_kitfamilia;
GO

CREATE PROCEDURE sp_delete_kitfamilia
@id_kit			     INT,
@id_fam_motor        INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from kitfamilia where id_kit=@id_kit and id_fam_motor=@id_fam_motor)
BEGIN
  --deleta logicamente dependencias existentes
  
  --realiza a exclusao logicamente
UPDATE kitfamilia SET flg_ativo = 0
WHERE id_kit=@id_kit and id_fam_motor=@id_fam_motor

END
ELSE
--retorna erro se n�o houver o codigo
RAISERROR('Item de peca inexistente!',16,1)
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