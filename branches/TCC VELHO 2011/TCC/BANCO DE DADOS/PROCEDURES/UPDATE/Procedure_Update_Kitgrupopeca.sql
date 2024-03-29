USE Megatechdatabase
IF OBJECT_ID('sp_update_kitgrupopeca', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_kitgrupopeca;
GO

CREATE PROCEDURE sp_update_kitgrupopeca
@id_kit        INT,
@id_kit_real   VARCHAR(10),
@nom           VARCHAR(50),
@flg_ativo     BIT,
@dat_alt       DATETIME

AS 
BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from kitgrupopeca where id_kit=@id_kit)
BEGIN
--Valida��es na tabela kitgrupopeca

--Update na tabela kitgrupopeca
UPDATE kitgrupopeca SET

id_kit_real  = @id_kit_real,
nom          = @nom, 
flg_ativo    = @flg_ativo,
dat_alt      = @dat_alt

WHERE id_kit = @id_kit

END
ELSE
--retorna erro se n�o houver o codigo
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