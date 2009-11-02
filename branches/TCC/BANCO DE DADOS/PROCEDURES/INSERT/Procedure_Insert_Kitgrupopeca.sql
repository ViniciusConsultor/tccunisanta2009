USE Megatechdatabase
IF OBJECT_ID('sp_insert_kitgrupopeca', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_kitgrupopeca;
GO

CREATE PROCEDURE sp_insert_kitgrupopeca
@id_kit_real   VARCHAR(10),
@nom           VARCHAR(50),
@dat_alt       DATETIME,
@flg_ativo     BIT

AS 
BEGIN TRY
--Validações na tabela kitgrupopeca
IF(@nom='')
   RAISERROR('Informe o nome do grupo de peças!',16,1)   
ELSE

BEGIN
--Insert na tabela itempeca
INSERT INTO KITGRUPOPECA(id_kit_real, nom, dat_alt, flg_ativo)
VALUES(@id_kit_real, @nom, @dat_alt, @flg_ativo)
END
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