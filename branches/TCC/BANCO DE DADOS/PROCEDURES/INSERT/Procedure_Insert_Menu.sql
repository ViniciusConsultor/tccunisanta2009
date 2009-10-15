USE Megatechdatabase
IF OBJECT_ID('sp_insert_menu', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_menu;
GO

CREATE PROCEDURE sp_insert_menu
@id_menu          INT,
@end_menu         VARCHAR(500),
@dsc_menu         VARCHAR(50),
@dat_atl          DATETIME,
@flg_ativo        BIT
AS

BEGIN TRY
--Valida��es na tabela menu
IF(@id_menu='')
   RAISERROR('Informe o codigo do menu!',16,1)   
ELSE IF(@end_menu='')
   RAISERROR('Informe o endereco do menu!',16,1)   
ELSE IF(@dsc_menu='')
   RAISERROR('Informe uma descricao para o menu!',16,1)   
ELSE

BEGIN
--Insert na tabela menu
INSERT INTO Menu(id_menu, end_menu, dsc_menu, dat_atl, flg_ativo)
VALUES (@id_menu, @end_menu, @dsc_menu, @dat_atl, @flg_ativo)
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