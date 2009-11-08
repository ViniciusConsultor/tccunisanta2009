USE Megatechdatabase
IF OBJECT_ID('sp_insert_vendaproduto', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_vendaproduto;
GO

CREATE PROCEDURE sp_insert_vendaproduto
@id_venda			INT,
@id_prdto			INT,
@qtd				INT,
@dat_alt			DATETIME,
@flg_ativo			BIT

AS
BEGIN TRY
--Validações na tabela  vendaordem
IF(@id_venda='')
  RAISERROR('Informe o código da venda!',16,1)  
ELSE IF(@id_prdto='')
  RAISERROR('Informe o código do produto!',16,1)     
ELSE

BEGIN
--Insert na tabela vendaordem
INSERT INTO Vendaproduto(id_venda, id_prdto, qtd, dat_alt, flg_ativo)
VALUES(@id_venda, @id_prdto, @qtd, @dat_alt, @flg_ativo)
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