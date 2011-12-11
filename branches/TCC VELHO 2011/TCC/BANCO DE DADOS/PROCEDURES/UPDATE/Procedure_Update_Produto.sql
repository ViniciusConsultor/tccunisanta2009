USE Megatechdatabase
IF OBJECT_ID('sp_update_produto', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_produto;
GO

CREATE PROCEDURE sp_update_produto
@id_prdto               INT,
@dsc_prdto				VARCHAR,
@id_fam_motor			INT,
@id_kit					INT,
@id_tipo_produto		INT,
@flg_ativo				BIT,
@dat_alt				DATETIME

AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from produto where id_prdto=@id_prdto)
BEGIN
--Validações na tabela produto

--Update na tabela produto
UPDATE produto SET

id_prdto         = @id_prdto,
dsc_prdto		 = @dsc_prdto,
id_fam_motor	 = @id_fam_motor,
id_kit			 = @id_kit,
id_tipo_produto	 = @id_tipo_produto,
flg_ativo		 = @flg_ativo,
dat_alt			 = @dat_alt

WHERE id_prdto=@id_prdto

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Produto inexistente!',16,1)

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