USE Megatechdatabase
IF OBJECT_ID('sp_update_usinagem', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_usinagem;
GO

CREATE PROCEDURE sp_update_usinagem
@id_usinagem           INT,
@id_peca               INT,
@dta_envio             DATETIME,
@flg_status            BIT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Usinagem where id_usinagem = @id_usinagem AND id_peca = @id_peca)
BEGIN
--Validações para a tabela Usinagem

--Update na tabela Usinagem
UPDATE Usinagem SET

id_peca                = @id_peca,
dta_envio              = @dta_envio,
flg_status             = @flg_status

WHERE id_usinagem = @id_usinagem AND id_peca = @id_peca

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Usinagem inexistente para esta peca!',16,1)

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