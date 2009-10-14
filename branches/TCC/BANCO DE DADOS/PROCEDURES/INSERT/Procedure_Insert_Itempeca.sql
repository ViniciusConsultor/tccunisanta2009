USE Megatechdatabase
IF OBJECT_ID('sp_insert_itempeca', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_itempeca;
GO

CREATE PROCEDURE sp_insert_itempeca
@id_item_peca     INT,
@id_peca          VARCHAR(20),
@nom_item_peca    VARCHAR(20),
@flg_ativo        BIT

AS 
BEGIN TRY
--Validações na tabela itempeca
IF(@id_item_peca='')
   RAISERROR('Informe o código do item da peça!',16,1)
ELSE IF(@id_peca='')
   RAISERROR('Informe o codigo da peça!',16,1)
ELSE

BEGIN
--Insert na tabela itempeca
INSERT INTO ITEMPECA(id_item_peca, id_peca, nom_item_peca, flg_ativo)
VALUES(@id_item_peca, @id_peca, @nom_item_peca, @flg_ativo)
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