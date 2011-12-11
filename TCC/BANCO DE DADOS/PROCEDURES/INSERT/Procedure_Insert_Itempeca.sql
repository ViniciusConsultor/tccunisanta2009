USE Megatechdatabase
IF OBJECT_ID('sp_insert_itempeca', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_itempeca;
GO

CREATE PROCEDURE sp_insert_itempeca
@id_item		  INT,
@id_peca          INT,
@qtd_peca		  INT,
@dat_alt		  DATETIME,
@flg_ativo        BIT

AS 
BEGIN TRY
--Validações na tabela itempeca
IF (@id_item = '')
	RAISERROR('Informe o codigo da Item!',16,1)
ELSE IF(@id_peca='')
   RAISERROR('Informe o codigo da Peça!',16,1)
ELSE

BEGIN
--Insert na tabela itempeca
INSERT INTO ITEMPECA(id_item, id_peca, qtd_peca, dat_alt, flg_ativo)
VALUES(@id_item, @id_peca, @qtd_peca, @dat_alt, @flg_ativo)
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