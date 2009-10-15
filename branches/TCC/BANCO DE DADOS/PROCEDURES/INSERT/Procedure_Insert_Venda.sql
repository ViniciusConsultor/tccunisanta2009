USE Megatechdatabase
IF OBJECT_ID('sp_insert_venda', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_venda;
GO

CREATE PROCEDURE sp_insert_venda
@id_venda           INT,
@id_motor           INT,
@id_grupo           INT,
@id_tipo_produto    INT,
@id_ordem_kit       INT,
@id_cli             INT,
@dat_venda          DATETIME,
@qtd_venda          INT,
@val_venda          NUMERIC(15,2),
@nota_fisc          VARCHAR(20),
@dat_saida          DATETIME
AS

BEGIN TRY
--Validações na tabela  venda
IF(@id_venda='')
  RAISERROR('Informe o código da venda!',16,1)
ELSE IF(@id_motor='' and @id_grupo='')
  RAISERROR('Informe o código do motor ou do grupo de peças!',16,1)
ELSE IF(@id_tipo_produto='')
  RAISERROR('Informe o tipo do produto!',16,1) 
ELSE IF(@id_ordem_kit='')
  RAISERROR('Informe o código da ordem de produção!',16,1)   
ELSE IF(@id_cli='')
  RAISERROR('Informe o código do cliente!',16,1)  
ELSE IF(@qtd_venda='')
  RAISERROR('Informe a quantidade da venda!',16,1)   
ELSE IF(@val_venda='')
  RAISERROR('Informe o valor da venda!',16,1)     
ELSE IF(@nota_fisc='')
  RAISERROR('Informe a nota fiscal da venda!',16,1)     
ELSE IF(@dat_saida='')
  RAISERROR('Informe a data de saida da venda!',16,1)       
ELSE

BEGIN
--Insert na tabela venda
INSERT INTO Venda(id_venda, id_motor, id_grupo, id_tipo_produto, id_ordem_kit, id_cli, dat_venda, qtd_venda, val_venda, nota_fisc, dat_saida)
VALUES(@id_venda, @id_motor, @id_grupo, @id_tipo_produto, @id_ordem_kit, @id_cli, @dat_venda, @qtd_venda, @val_venda, @nota_fisc, @dat_saida)
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
