USE Megatechdatabase
IF OBJECT_ID('sp_update_venda', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_venda;
GO

CREATE PROCEDURE sp_update_venda
@id_venda           INT,
@id_tipo_produto    INT,
@id_ordem           INT,
@id_cli             INT,
@dat_venda          DATETIME,
@qtd                INT,
@valor              NUMERIC(15,2),
@nota_fisc          VARCHAR(20),
@dat_saida          DATETIME
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Venda where id_venda=@id_venda)
BEGIN
--Validações na tabela  venda

--Update na tabela venda
UPDATE Venda SET

id_tipo_produto   = @id_tipo_produto, 
id_ordem          = @id_ordem, 
id_cli            = @id_cli, 
dat_venda         = @dat_venda, 
qtd               = @qtd, 
valor             = @valor, 
nota_fisc         = @nota_fisc, 
dat_saida         = @dat_saida

WHERE id_venda = @id_venda

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Venda inexistente!',16,1)

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
