USE Megatechdatabase
IF OBJECT_ID('sp_update_peca', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_peca;
GO

CREATE PROCEDURE sp_update_peca
@id_peca               INT,
@id_peca_real          VARCHAR(50),
@id_tipo_peca          INT,
@nom				   VARCHAR(50),
@dsc_peca              VARCHAR(500),
@qtd_min               INT,
@peso                  DECIMAL(10,2),
@dat_alt               DATETIME,
@flg_ativo             BIT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Peca where id_peca=@id_peca)
BEGIN
--Validações na tabela peca

--Update na tabela peca
UPDATE peca SET

id_peca_real         = @id_peca_real,
id_tipo_peca         = @id_tipo_peca, 
nom                  = @nom, 
dsc_peca             = @dsc_peca, 
qtd_min              = @qtd_min,
peso                 = @peso, 
dat_alt              = @dat_alt, 
flg_ativo            = flg_ativo

WHERE id_peca=@id_peca

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Peca inexistente!',16,1)

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