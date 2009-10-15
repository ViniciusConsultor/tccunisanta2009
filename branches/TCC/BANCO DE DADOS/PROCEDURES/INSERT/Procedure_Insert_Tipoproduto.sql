USE Megatechdatabase
IF OBJECT_ID('sp_insert_tipoproduto', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_tipoproduto;
GO

CREATE PROCEDURE sp_insert_tipoproduto
@id_tipo_produto       INT,
@nom_tipo_produto      VARCHAR(100),
@dat_alt               DATETIME,
@flg_ativo             BIT
AS

BEGIN TRY
--Validações na tabela tipoproduto   
IF(@id_tipo_produto='')
   RAISERROR('Informe o codigo do tipo da produto!',16,1)
IF(@nom_tipo_produto='')
   RAISERROR('Informe o nome do tipo da produto!',16,1)  
ELSE

BEGIN
--Insert na tabela tipoproduto
INSERT INTO TIPOPRODUTO(id_tipo_produto, nom_tipo_produto, dat_alt, flg_ativo)
VALUES (@id_tipo_produto, @nom_tipo_produto, @dat_alt, @flg_ativo)
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