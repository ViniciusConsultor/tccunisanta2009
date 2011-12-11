USE Megatechdatabase
IF OBJECT_ID('sp_insert_estoque', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_estoque;
GO

CREATE PROCEDURE sp_insert_estoque
@id_estoq     INT,
@id_depto     INT,
@dsc_estoq    VARCHAR(100),
@dat_alt      DATETIME,
@flg_negativo BIT,
@flg_ativo    BIT

AS 
BEGIN TRY
--Validações na tabela estoque
IF(@id_depto='')
   RAISERROR('Informe o código do departamento deste estoque!',16,1)
ELSE IF(@dsc_estoq='')
   RAISERROR('Informe o nome do estoque!',16,1)
ELSE
BEGIN
--Insert na tabela estoque
INSERT INTO ESTOQUE(id_estoq, id_depto, dsc_estoq, dat_alt, flg_ativo, flg_negativo)
VALUES(@id_estoq, @id_depto, @dsc_estoq, @dat_alt, @flg_ativo, @flg_negativo)
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