USE Megatechdatabase
IF OBJECT_ID('sp_update_kitgrupopeca', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_kitgrupopeca;
GO

CREATE PROCEDURE sp_update_kitgrupopeca
@id_grupo      INT,
@id_peca       VARCHAR(20),
@id_item_peca  INT,
@nom     VARCHAR(50),
@flg_ativo     BIT

AS 
BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from kitgrupopeca where id_grupo=@id_grupo)
BEGIN
--Validações na tabela kitgrupopeca

--Update na tabela itempeca
UPDATE kitgrupopeca SET

id_peca      = @id_peca, 
id_item_peca = @id_item_peca, 
nom     = @nom, 
flg_ativo    = @flg_ativo

WHERE id_grupo=@id_grupo

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Grupo de pecas inexistente!',16,1)

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