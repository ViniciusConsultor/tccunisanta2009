USE Megatechdatabase
IF OBJECT_ID('sp_update_compra', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_compra;
GO

CREATE PROCEDURE sp_update_compra
@id_compra               INT,
@id_depto                INT,
@id_fornecedor           INT,
@id_motor_compra         INT,
@id_tipo_produto         INT,
@id_peca                 INT,
@dat_compra              DATETIME,
@qtd_comp                INT,
@val_comp                NUMERIC(15,2),
@nro_nota_fiscal         INT,
@obs_compra              VARCHAR(20)
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Compra where id_compra=@id_compra)
BEGIN
--Validações para a tabela compra

--Update na tabela compra
UPDATE Compra SET

id_depto               = @id_depto, 
id_fornecedor          = @id_fornecedor, 
id_motor_compra        = @id_motor_compra, 
id_tipo_produto        = @id_tipo_produto, 
id_peca                = @id_peca, 
dat_compra             = @dat_compra, 
qtd_comp               = @qtd_comp, 
val_comp               = @val_comp, 
nro_nota_fiscal        = @nro_nota_fiscal, 
obs_compra             = @obs_compra

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