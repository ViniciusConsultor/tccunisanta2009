USE Megatechdatabase
IF OBJECT_ID('sp_insert_itemkit', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_itemkit;
GO

CREATE PROCEDURE sp_insert_itemkit
@id_item		  INT,
@id_kit			  INT,
@dat_alt		  DATETIME,
@flg_ativo        BIT

AS 
BEGIN TRY
--Valida��es na tabela itempeca
IF(@id_item='')
   RAISERROR('Informe o c�digo do Item!',16,1)   
ELSE IF(@id_kit='')
   RAISERROR('Informe o c�digo do Kit!',16,1)   
ELSE

BEGIN
--Insert na tabela itempeca
INSERT INTO ITEMKIT(id_item, id_kit, dat_alt, flg_ativo)
VALUES(@id_item, @id_kit, @dat_alt, @flg_ativo)
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