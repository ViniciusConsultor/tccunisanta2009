USE Megatechdatabase
IF OBJECT_ID('sp_insert_usinagem', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_usinagem;
GO

CREATE PROCEDURE sp_insert_usinagem
@id_usinagem       INT,
@id_peca           INT,
@dta_envio         DATETIME,
@flg_status        BIT
AS

BEGIN TRY
--Validações na tabela Usinagem
IF(@id_usinagem='')
   RAISERROR('Informe o codigo da usinagem!',16,1)   
ELSE IF(@id_peca='')
   RAISERROR('Informe o codigo da peca!',16,1)   
ELSE IF(@dta_envio='')
   RAISERROR('Informe a data de envio da peca para a usinagem!',16,1)       
ELSE

BEGIN
--Insert na tabela Usinagem
INSERT INTO Usinagem(id_usinagem, id_peca, dta_envio, flg_status)
VALUES (@id_usinagem, @id_peca, @dta_envio, @flg_status)
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