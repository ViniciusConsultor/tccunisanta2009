USE Megatechdatabase
IF OBJECT_ID('sp_insert_ordemproducao', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_ordemproducao;
GO

CREATE PROCEDURE sp_insert_ordemproducao
@id_tipo_produto    INT,
@id_depto           INT,
@id_fam_motor       INT,
@id_kit           INT,
@dsc_ordem          VARCHAR(500)
AS

BEGIN TRY
--Validações na tabela ordemproducao  
IF(@id_tipo_produto='')
   RAISERROR('Informe o tipo do produto!',16,1)   
ELSE IF(@id_depto='')
   RAISERROR('Informe o departamento da ordem!',16,1)
ELSE IF(@dsc_ordem='')
   RAISERROR('Informe uma descricao para a ordem!',16,1)   
ELSE IF(@id_fam_motor='' and @id_kit='')
   RAISERROR('Informe o código do motor ou do grupo de peças!',16,1)
ELSE

BEGIN
--Insert na tabela ordemproducao
INSERT INTO ORDEMPRODUCAO(id_tipo_produto, id_depto, id_fam_motor, id_kit, dsc_ordem)
VALUES (@id_tipo_produto, @id_depto, @id_fam_motor, @id_kit, @dsc_ordem)
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