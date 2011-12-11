USE Megatechdatabase
IF OBJECT_ID('sp_update_compra', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_compra;
GO

CREATE PROCEDURE sp_update_compra
@id_compra        INT,
@id_forn          INT,
@dat              DATETIME,
@valor            NUMERIC(15,2),
@nota_fisc        VARCHAR(50),
@obs              VARCHAR(500)
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Compra where id_compra=@id_compra)
BEGIN
--Validações para a tabela compra

--Update na tabela compra
UPDATE Compra SET
 
id_forn         = @id_forn,  
dat             = @dat, 
valor           = @valor, 
nota_fisc       = @nota_fisc, 
obs             = @obs

WHERE id_compra = @id_compra

END
ELSE
--retorna erro se não houver o codigo
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