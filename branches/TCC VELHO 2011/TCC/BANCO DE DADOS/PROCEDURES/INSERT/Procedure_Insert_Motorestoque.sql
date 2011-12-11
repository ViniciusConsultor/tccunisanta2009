USE Megatechdatabase
IF OBJECT_ID('sp_insert_motorestoque', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_motorestoque;
GO

CREATE PROCEDURE sp_insert_motorestoque
@id_estoq	 INT,
@id_motor	 INT,
@dat_alt	 DATETIME,
@flg_ativo   BIT,
@qtd		 INT
AS

BEGIN TRY
--Validações na tabela motorfornecedor
IF(@id_estoq='')
   RAISERROR('Informe o código do estoque!',16,1)
ELSE IF(@id_motor='')
   RAISERROR('Informe o código do motor!',16,1)
BEGIN
--Insert na tabela motorfornecedor
INSERT INTO Motorestoque(id_motor,id_estoq, dat_alt, flg_ativo, qtd)
VALUES (@id_motor, @id_estoq, @dat_alt, @flg_ativo, @qtd)
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