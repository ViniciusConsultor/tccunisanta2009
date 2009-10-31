USE Megatechdatabase
IF OBJECT_ID('sp_update_pecafornecedor', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_pecafornecedor;
GO

CREATE PROCEDURE sp_update_pecafornecedor
@id_peca               INT,
@id_forn			   INT,
@dat_inc               DATETIME,
@flg_ativo             BIT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Pecafornecedor where id_peca = @id_peca AND id_forn = @id_forn)
BEGIN
--Valida��es para a tabela pecafornecedor

--Update na tabela pecafornecedor
UPDATE Pecafornecedor SET

id_peca                = @id_peca,
id_forn                = @id_forn,
dat_inc                = @dat_inc,
flg_ativo              = @flg_ativo

WHERE id_peca = @id_peca AND id_forn = @id_forn

END
ELSE
--retorna erro se n�o houver o codigo
RAISERROR('Peca inexistente para este fornecedor!',16,1)

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