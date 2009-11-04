USE Megatechdatabase
IF OBJECT_ID('sp_insert_compra', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_compra;
GO

CREATE PROCEDURE sp_insert_compra
@id_compra        INT,
@dat              DATETIME,
@valor            NUMERIC(15,2),
@obs              VARCHAR(500)
AS

BEGIN TRY
--Validações para a tabela compra
IF(@dat='')
   RAISERROR('Informe a data da compra!',16,1)
ELSE IF(CONVERT(VARCHAR(15), @valor)='')
   RAISERROR('Informe o valor da compra!',16,1)
ELSE IF(@obs='')
   RAISERROR('Informe alguma observacao para a compra!',16,1)
ELSE

BEGIN
--Insert na tabela compra
INSERT INTO 
Compra(id_compra, dat, valor, obs)
VALUES(@id_compra, @dat, @valor, @obs)
END
END TRY

BEGIN CATCH
DECLARE @ErrorMessage NVARCHAR(4000);
DECLARE @ErrorSeverity INT;
DECLARE @ErrorState INT;
SELECT
@ErrorMessage=ERROR_MESSAGE(),
@ErrorSeverity=ERROR_SEVERITY(),
@ErrorState=ERROR_STATE();
--Use RAISERROR inside the CATCH block to return error
--information about the original error that caused
--execution to jump to the CATCH block.
RAISERROR(
@ErrorMessage, --Message text
@ErrorSeverity, --Severity
@ErrorState --State
);
END CATCH;