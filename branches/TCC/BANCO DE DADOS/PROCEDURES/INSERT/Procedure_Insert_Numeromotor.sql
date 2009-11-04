USE Megatechdatabase
IF OBJECT_ID('sp_insert_ordemcompra', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_ordemcompra;
GO

CREATE PROCEDURE sp_insert_ordemcompra
@id_ordem_compra   INT,
@id_peca		   INT,
@ultim_preco	   NUMERIC(15,2),
@id_motor			   INT,
@dat_alt		   DATETIME,
@nota_fisc		   VARCHAR(20),
@id_forn		   INT,
@flg_ativo         BIT
AS

BEGIN TRY
--Validações na tabela ordemcompra

BEGIN
--Insert na tabela ordemcompra
INSERT INTO ordemcompra (id_ordem_compra, id_peca, ultim_preco, id_motor, dat_alt, nota_fisc, id_forn, flg_ativo)
VALUES (@id_ordem_compra, @id_peca, @ultim_preco, @id_motor, @dat_alt, @nota_fisc, @id_forn, @flg_ativo)
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