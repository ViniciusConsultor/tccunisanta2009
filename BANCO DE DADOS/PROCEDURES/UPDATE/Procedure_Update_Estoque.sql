USE Megatechdatabase
IF OBJECT_ID('sp_update_estoque', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_estoque;
GO

CREATE PROCEDURE sp_update_estoque
@id_estoque       INT,
@id_depto         INT,
@nom_estoque      VARCHAR(100),
@dat_alt          DATETIME,
@flg_ativo        BIT

AS 
BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Estoque where id_estoque=@id_estoque)
BEGIN
--Validações na tabela estoque

--Insert na tabela estoque
UPDATE ESTOQUE SET

id_depto     = @id_depto, 
nom_estoque  = @nom_estoque, 
dat_alt      = @dat_alt, 
flg_ativo    = @flg_ativo

WHERE id_estoque = @id_estoque

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Estoque inexistente!',16,1)

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