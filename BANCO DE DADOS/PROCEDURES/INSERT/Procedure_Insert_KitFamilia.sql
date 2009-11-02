USE Megatechdatabase
IF OBJECT_ID('sp_insert_kitfamilia', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_kitfamilia;
GO

CREATE PROCEDURE sp_insert_kitfamilia
@id_kit        INT,
@id_fam_motor  INT,
@dat_alt       DATETIME,
@flg_ativo     BIT

AS 
BEGIN TRY
--Validações na tabela kitgrupopeca
IF(@id_kit='')
   RAISERROR('Informe o codigo do grupo de peças!',16,1)   
ELSE IF(@id_fam_motor='')
   RAISERROR('Informe o codigo da familia de motores!',16,1)   
ELSE

BEGIN
--Insert na tabela itempeca
INSERT INTO KITFAMILIA(id_kit, id_fam_motor, dat_alt, flg_ativo)
VALUES(@id_kit, @id_fam_motor, @dat_alt, @flg_ativo)
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