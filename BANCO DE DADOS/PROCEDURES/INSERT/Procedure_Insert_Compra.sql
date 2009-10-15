USE Megatechdatabase
IF OBJECT_ID('sp_insert_compra', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_compra;
GO

CREATE PROCEDURE sp_insert_compra
@id_compra        INT,
@id_depto         INT,
@id_fornecedor    INT,
@id_motor_compra  INT,
@id_tipo_produto  INT,
@id_peca          VARCHAR(20),
@dat_compra       DATETIME,
@qtd_comp         INT,
@val_comp         NUMERIC(15,2),
@nro_nota_fiscal  INT,
@obs_compra       VARCHAR(20)
AS

BEGIN TRY
--Validações para a tabela compra
IF (@id_compra='')
   RAISERROR('Informe o código da compra!',16,1)
ELSE IF(@id_depto='')
   RAISERROR('Informe o departamento da compra!',16,1)
ELSE IF(@id_fornecedor='')
   RAISERROR('Informe o fornecedor da compra!',16,1)
ELSE IF(@id_tipo_produto='')
   RAISERROR('Informe o tipo do produto!',16,1)
ELSE IF(@dat_compra='')
   RAISERROR('Informe a data da compra!',16,1)
ELSE IF(@qtd_comp='')
   RAISERROR('Informe a quantidade da compra!',16,1)
ELSE IF(@val_comp='')
   RAISERROR('Informe o valor da compra!',16,1)
ELSE IF(@nro_nota_fiscal='')
   RAISERROR('Informe o número da nota fiscal!',16,1)
ELSE IF(@obs_compra='')
   RAISERROR('Informe alguma observacao para a compra!',16,1)
ELSE IF(@id_motor_compra='' and @id_peca='')
   RAISERROR('Informe o codigo do motor ou da peca!',16,1)   
ELSE

BEGIN
--Insert na tabela compra
INSERT INTO 
Compra(id_compra, id_depto, id_fornecedor, id_motor_compra, id_tipo_produto, id_peca, dat_compra, qtd_comp, val_comp, nro_nota_fiscal, obs_compra)
VALUES(@id_compra, @id_depto, @id_fornecedor, @id_motor_compra, @id_tipo_produto, @id_peca, @dat_compra, @qtd_comp, @val_comp, @nro_nota_fiscal, @obs_compra)
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