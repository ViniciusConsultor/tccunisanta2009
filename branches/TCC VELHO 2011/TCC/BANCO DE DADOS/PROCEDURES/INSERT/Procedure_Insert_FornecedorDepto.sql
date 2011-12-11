USE Megatechdatabase
IF OBJECT_ID('sp_insert_fornecedordepto', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_fornecedordepto;
GO

CREATE PROCEDURE sp_insert_fornecedordepto
@id_depto		  INT,
@id_forn		  INT,
@dat_alt		  DATETIME,
@flg_ativo        BIT

AS 
BEGIN TRY
--Validações na tabela itempeca


BEGIN
--Insert na tabela itempeca
INSERT INTO fornecedordepto(id_depto, id_forn, dat_alt, flg_ativo)
VALUES (@id_depto, @id_forn, @dat_alt, @flg_ativo)
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