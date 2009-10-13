USE Megatechdatabase
IF OBJECT_ID('sp_insert_perfil', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_perfil;
GO

CREATE PROCEDURE sp_insert_perfil
@id_perfil INT,
@dsc_perfil VARCHAR(30),
@dat_atl DATETIME,
@flg_ativo BIT
AS
BEGIN TRY
IF(@id_perfil='')
   RAISERROR('Informe o codigo do perfil!',16,1)
ELSE
BEGIN
INSERT INTO Perfil (id_perfil, dsc_perfil, dat_atl, flg_ativo)
VALUES(@id_perfil, @dsc_perfil, @dat_atl, @flg_ativo)
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