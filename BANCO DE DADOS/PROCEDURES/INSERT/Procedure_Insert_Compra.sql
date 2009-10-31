USE Megatechdatabase
IF OBJECT_ID('sp_insert_compra', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_compra;
GO

CREATE PROCEDURE sp_insert_compra
@id_depto         INT,
@id_forn          INT,
@id_motor         INT,
@id_tipo_produto  INT,
@dat              DATETIME,
@qtd              INT,
@valor            NUMERIC(15,2),
@nota_fisc        VARCHAR(50),
@obs              VARCHAR(500)
AS

BEGIN TRY
--Validações para a tabela compra
IF(@id_depto='')
   RAISERROR('Informe o departamento da compra!',16,1)
ELSE IF(@id_forn='')
   RAISERROR('Informe o fornecedor da compra!',16,1)
ELSE IF(@id_tipo_produto='')
   RAISERROR('Informe o tipo do produto!',16,1)
ELSE IF(@dat='')
   RAISERROR('Informe a data da compra!',16,1)
ELSE IF(@qtd='')
   RAISERROR('Informe a quantidade da compra!',16,1)
ELSE IF(CONVERT(VARCHAR(15), @valor)='')
   RAISERROR('Informe o valor da compra!',16,1)
ELSE IF(@nota_fisc='')
   RAISERROR('Informe o número da nota fiscal!',16,1)
ELSE IF(@obs='')
   RAISERROR('Informe alguma observacao para a compra!',16,1)
ELSE IF(@id_motor='')
   RAISERROR('Informe o codigo do motor!',16,1)   
ELSE

BEGIN
--Insert na tabela compra
INSERT INTO 
Compra(id_depto, id_forn, id_motor, id_tipo_produto, dat, qtd, valor, nota_fisc, obs)
VALUES(@id_depto, @id_forn, @id_motor, @id_tipo_produto, @dat, @qtd, @valor, @nota_fisc, @obs)
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