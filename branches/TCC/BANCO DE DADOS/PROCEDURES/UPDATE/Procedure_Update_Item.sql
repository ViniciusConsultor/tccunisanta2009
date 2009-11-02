USE Megatechdatabase
IF OBJECT_ID('sp_update_item', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_item;
GO

CREATE PROCEDURE sp_update_item
@id_item	      INT,
@nom              VARCHAR(20),
@flg_ativo        BIT,
@dat_alt		  DATETIME

AS 
BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from item where id_item=@id_item)
BEGIN
--Validações na tabela item

--Insert na tabela item
UPDATE item SET
nom          = @nom, 
flg_ativo    = @flg_ativo,
dat_alt		 = @dat_alt

WHERE id_item=@id_item

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Item inexistente!',16,1)

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