USE Megatechdatabase
IF OBJECT_ID('sp_insert_pedidovenda', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_pedidovenda;
GO

CREATE PROCEDURE sp_insert_pedidovenda
@id_pedido        INT,
@id_venda         INT,
@id_depto         INT,
@dsc_venda        VARCHAR(500),
@dat_alt          DATETIME,
@id_fam_motor	  INT,
@id_grupo		  INT
AS

BEGIN TRY
--Validações na tabela pedidovenda
IF(@id_venda='')
   RAISERROR('Informe o codigo da venda!',16,1)   
ELSE IF(@id_pedido='')
   RAISERROR('Informe o do codigo do pedido!',16,1)   
ELSE IF(@id_depto='')
   RAISERROR('Informe o codigo do departamento!',16,1)     
ELSE

BEGIN
--Insert na tabela pedidovenda
INSERT INTO PEDIDOVENDA(id_venda, id_pedido, id_depto, dsc_venda, dat_alt, id_fam_motor, id_grupo)
VALUES (@id_venda, @id_pedido, @id_depto, @dsc_venda, @dat_alt, @id_fam_motor, @id_grupo)
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