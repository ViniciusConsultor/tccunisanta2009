USE Megatechdatabase
IF OBJECT_ID('sp_update_itemkit', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_itemkit;
GO

CREATE PROCEDURE sp_update_itemkit
@id_item	     INT,
@id_kit			 INT,
@dat_alt		 DATETIME,
@flg_ativo       BIT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from itemkit where id_item=@id_item and id_kit=@id_kit)
BEGIN
--Validações na tabela itemkit

--Update na tabela itemkit
UPDATE itemkit SET
id_item		   = @id_item,
id_kit		   = @id_kit,
dat_alt		   = @dat_alt, 
flg_ativo      = @flg_ativo

WHERE id_item=@id_item and id_kit=@id_kit

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Item inexistente neste Kit!',16,1)

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