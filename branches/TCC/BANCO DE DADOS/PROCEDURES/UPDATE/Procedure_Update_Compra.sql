USE Megatechdatabase
IF OBJECT_ID('sp_update_compra', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_compra;
GO

CREATE PROCEDURE sp_update_compra
@id_compra               INT,
@id_depto                INT,
@id_forn           INT,
@id_motor         INT,
@id_tipo_produto         INT,
@id_peca                 INT,
@dat              DATETIME,
@qtd                INT,
@valor                NUMERIC(15,2),
@nota_fisc         INT,
@obs              VARCHAR(20)
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Compra where id_compra=@id_compra)
BEGIN
--Valida��es para a tabela compra

--Update na tabela compra
UPDATE Compra SET

id_depto               = @id_depto, 
id_forn          = @id_forn, 
id_motor        = @id_motor, 
id_tipo_produto        = @id_tipo_produto, 
id_peca                = @id_peca, 
dat             = @dat, 
qtd               = @qtd, 
valor               = @valor, 
nota_fisc        = @nota_fisc, 
obs             = @obs

WHERE id_compra = @id_compra

END
ELSE
--retorna erro se n�o houver o codigo
RAISERROR('Compra inexistente!',16,1)

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