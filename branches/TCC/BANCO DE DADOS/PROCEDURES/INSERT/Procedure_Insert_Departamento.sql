USE Megatechdatabase
IF OBJECT_ID('sp_insert_departamento', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_departamento;
GO

CREATE PROCEDURE sp_insert_departamento
@id_depto	 INT,
@dsc_depto   VARCHAR(30),
@dat_atl     DATETIME,
@flg_ativo   BIT
AS
BEGIN TRY
--Validacoes para a tabela Departamento
IF(@dsc_depto = '')
   RAISERROR('Informe o nome do departamento!',16,1)
BEGIN
--Insert na tabela departamento
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, flg_ativo)
VALUES (@id_depto, @dsc_depto, @dat_atl, @flg_ativo)
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