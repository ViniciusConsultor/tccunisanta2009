USE Megatechdatabase
IF OBJECT_ID('sp_update_tipoproduto', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_tipoproduto;
GO

CREATE PROCEDURE sp_update_tipoproduto
@id_tipo_produto       INT,
@nom_tipo_produto      VARCHAR(100),
@dat_alt               DATETIME,
@flg_ativo             BIT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from tipoproduto where id_tipo_produto=@id_tipo_produto)
BEGIN
--Validações na tabela tipoproduto   

--Update na tabela tipoproduto
UPDATE tipoproduto SET

nom_tipo_produto = @nom_tipo_produto, 
dat_alt          = @dat_alt, 
flg_ativo        = @flg_ativo

WHERE id_tipo_produto = @id_tipo_produto

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Tipo de produto inexistente!',16,1)

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