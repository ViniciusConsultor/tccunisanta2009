USE Megatechdatabase
IF OBJECT_ID('sp_insert_ordemdepartamento', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_ordemdepartamento;
GO

CREATE PROCEDURE sp_insert_ordemdepartamento
@id_depto		    INT,
@id_ordem	        INT,
@flg_ativo	        BIT,
@dat_alt            DATETIME
AS

BEGIN TRY
--Validações na tabela ordemdepartamento  
IF(@id_depto='')
   RAISERROR('Informe o código do departamento!',16,1)   
ELSE IF(@id_ordem='')
   RAISERROR('Informe o código da Ordem!',16,1)   
ELSE

BEGIN
--Insert na tabela ordemdepartamento
INSERT INTO ordemdepartamento(id_depto, id_ordem, dat_alt, flg_ativo)
VALUES (@id_depto, @id_ordem, @dat_alt, @flg_ativo)
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