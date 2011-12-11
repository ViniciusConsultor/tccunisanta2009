USE Megatechdatabase
IF OBJECT_ID('sp_insert_fornecedordepartamento', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_fornecedordepartamento;
GO

CREATE PROCEDURE sp_insert_fornecedordepartamento
@id_forn          INT,
@id_depto         INT,
@dat_alt          DATETIME,
@flg_ativo        BIT

AS 
BEGIN TRY
--Validações na tabela fornecedordepartamento
IF(@id_forn='')
   RAISERROR('Informe o código do fornecedor!',16,1)
ELSE IF(@id_depto='')
   RAISERROR('Informe o codigo do departamento!',16,1)
ELSE

BEGIN
--Insert na tabela fornecedordepartamento
INSERT INTO FORNECEDORDEPARTAMENTO(id_forn, id_depto, dat_alt, flg_ativo)
VALUES(@id_forn, @id_depto, @dat_alt, @flg_ativo)
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