USE Megatechdatabase
IF OBJECT_ID('sp_update_motorcompra', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_motorcompra;
GO

CREATE PROCEDURE sp_update_motorcompra
@id_motor_compra    INT,
@dsc_motor_compra   VARCHAR(100),
@flg_ativo          BIT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Motor where id_motor_compra=@id_motor_compra)
BEGIN
--Validações na tabela motor

--Update na tabela motor
UPDATE Motor SET

dsc_motor_compra = @dsc_motor_compra, 
flg_ativo        = @flg_ativo

WHERE id_motor_compra=@id_motor_compra

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Motor inexistente!',16,1)

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