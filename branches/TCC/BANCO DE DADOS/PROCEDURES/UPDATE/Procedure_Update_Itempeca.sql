USE Megatechdatabase
IF OBJECT_ID('sp_update_itempeca', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_itempeca;
GO

CREATE PROCEDURE sp_update_itempeca
@id_item_peca     INT,
@id_peca          VARCHAR(20),
@nom_item_peca    VARCHAR(20),
@flg_ativo        BIT

AS 
BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from itempeca where id_item_peca=@id_item_peca and id_peca=@id_peca)
BEGIN
--Validações na tabela itempeca

--Insert na tabela itempeca
UPDATE itempeca SET

nom_item_peca = @nom_item_peca, 
flg_ativo    = @flg_ativo

WHERE id_item_peca=@id_item_peca and id_peca=@id_peca

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Item de pecas inexistente!',16,1)

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