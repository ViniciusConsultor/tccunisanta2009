USE Megatechdatabase
IF OBJECT_ID('sp_update_tipopeca', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_tipopeca;
GO

CREATE PROCEDURE sp_update_tipopeca
@id_tipo_peca    INT,
@dsc_tipo_peca   VARCHAR(500),
@flg_ativo       BIT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from tipopeca where id_tipo_peca=@id_tipo_peca)
BEGIN
--Validações na tabela tipopeça

--Update na tabela tipopeça
UPDATE tipodepeca SET

dsc_tipo_peca  = @dsc_tipo_peca, 
flg_ativo      = @flg_ativo

WHERE id_tipo_peca=@id_tipo_peca

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Tipo de peca inexistente!',16,1)

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