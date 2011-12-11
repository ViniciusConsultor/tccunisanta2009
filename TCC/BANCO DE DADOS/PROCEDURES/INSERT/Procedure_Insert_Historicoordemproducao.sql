USE Megatechdatabase
IF OBJECT_ID('sp_insert_historicoordemproducao', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_historicoordemproducao;
GO

CREATE PROCEDURE sp_insert_historicoordemproducao
@id_ordem_prod		INT,
@id_stat_ordem	    INT,
@dat_atl			DATETIME
AS

BEGIN TRY
--Validações na tabela compraordemcompra
IF(@id_ordem_prod='')
   RAISERROR('Informe o codigo da Ordem de Producao!',16,1)   
ELSE IF(@id_stat_ordem='')
   RAISERROR('Informe o codigo do status da Ordem de Producao!',16,1)   
ELSE IF(@dat_atl='')
RAISERROR('Informe a data de alteracao!',16,1)  
ELSE

BEGIN
--Insert na tabela compraordemcompra
INSERT INTO Historicoordemproducao(id_ordem_prod, id_stat_ordem, dat_atl)
VALUES (@id_ordem_prod, @id_stat_ordem, @dat_atl)
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