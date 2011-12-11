USE Megatechdatabase
IF OBJECT_ID('sp_update_pecaestoque', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_pecaestoque;
GO

CREATE PROCEDURE sp_update_pecaestoque
@id_peca               INT,
@id_estoq			   INT,
@qtd_peca			   INT,
@dat_alt               DATETIME,
@flg_ativo             BIT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Pecaestoque where id_peca=@id_peca and id_estoq=@id_estoq)
BEGIN
--Validações na tabela pecaestoque

--Update na tabela pecaestoque
UPDATE pecaestoque SET

id_peca		         = @id_peca,
id_estoq			 = @id_estoq,
qtd_peca			 = @qtd_peca,
dat_alt              = @dat_alt, 
flg_ativo            = flg_ativo

WHERE id_peca=@id_peca and id_estoq=@id_estoq

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Peca não cadastrada neste estoque!',16,1)

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