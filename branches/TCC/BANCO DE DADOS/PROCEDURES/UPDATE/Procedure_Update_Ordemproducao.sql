USE Megatechdatabase
IF OBJECT_ID('sp_update_ordemproducao', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_ordemproducao;
GO

CREATE PROCEDURE sp_update_ordemproducao
@id_ordem           INT,
@id_tipo_produto    INT,
@id_fam_motor       INT,
@id_kit				INT,
@dsc_ordem          VARCHAR(500)
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from ordemproducao where id_ordem=@id_ordem)
BEGIN
--Validações na tabela ordemproducao

--Insert na tabela ordemproducao
UPDATE ordemproducao SET

id_tipo_produto = @id_tipo_produto, 
id_fam_motor    = @id_fam_motor, 
id_kit          = @id_kit, 
dsc_ordem       = @dsc_ordem

WHERE id_ordem = @id_ordem

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Ordem de producao inexistente!',16,1)

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