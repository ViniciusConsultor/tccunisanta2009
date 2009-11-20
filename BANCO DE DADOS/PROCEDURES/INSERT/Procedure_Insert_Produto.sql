USE Megatechdatabase
IF OBJECT_ID('sp_insert_Produto', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_Produto;
GO

CREATE PROCEDURE sp_insert_Produto
@id_prdto			INT,
@dsc_prdto          VARCHAR(500),
@id_fam_motor		INT,
@id_kit				INT,
@id_tipo_produto	INT,
@flg_ativo			BIT,
@dat_alt			DATETIME

AS

BEGIN TRY
--Validações na tabela ordemproducao  
IF(@id_tipo_produto='')
   RAISERROR('Informe o tipo do produto!',16,1)   
ELSE IF(@dsc_prdto='')
   RAISERROR('Informe uma descricao para a ordem!',16,1)   
ELSE IF(@id_fam_motor='' and @id_kit='')
   RAISERROR('Informe o código do motor ou do grupo de peças!',16,1)
ELSE

BEGIN
--Insert na tabela ordemproducao
INSERT INTO Produto(id_prdto, dsc_prdto, id_fam_motor, id_kit, id_tipo_produto, flg_ativo, dat_alt)
VALUES (@id_prdto, @dsc_prdto, @id_fam_motor, @id_kit, @id_tipo_produto, @flg_ativo, @dat_alt)
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