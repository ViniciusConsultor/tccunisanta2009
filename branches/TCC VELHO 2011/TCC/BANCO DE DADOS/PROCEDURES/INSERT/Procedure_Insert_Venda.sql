USE Megatechdatabase
IF OBJECT_ID('sp_insert_venda', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_venda;
GO

CREATE PROCEDURE sp_insert_venda
@id_venda			INT,
@id_cli             INT,
@dat_venda          DATETIME,
@valor				NUMERIC(15,2),
@nota_fisc          VARCHAR(20),
@dat_saida          DATETIME
AS
BEGIN TRY
--Valida��es na tabela  venda
IF(@id_cli='')
  RAISERROR('Informe o c�digo do cliente!',16,1)  
ELSE IF(CONVERT(VARCHAR, @valor)='')
  RAISERROR('Informe o valor da venda!',16,1)     
ELSE IF(@nota_fisc='')
  RAISERROR('Informe a nota fiscal da venda!',16,1)     
ELSE IF(@dat_saida='')
  RAISERROR('Informe a data de saida da venda!',16,1)       
ELSE

BEGIN
--Insert na tabela venda
INSERT INTO Venda(id_venda, id_cli, dat_venda, valor, nota_fisc, dat_saida)
VALUES(@id_venda, @id_cli, @dat_venda, @valor, @nota_fisc, @dat_saida)
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