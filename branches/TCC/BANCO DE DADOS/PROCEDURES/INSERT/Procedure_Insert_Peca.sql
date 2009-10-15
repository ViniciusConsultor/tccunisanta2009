USE Megatechdatabase
IF OBJECT_ID('sp_insert_peca', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_peca;
GO

CREATE PROCEDURE sp_insert_peca
@id_peca              VARCHAR(20),
@id_tipo_peca         INT,
@id_estoque           INT,
@nom_peca             VARCHAR(50),
@dsc_peca             VARCHAR(100),
@peso                 DECIMAL(10,2),
@qtd_minima           INT,
@dat_alt              DATETIME,
@flg_ativo            BIT
AS

BEGIN TRY
--Valida��es na tabela peca
IF(@id_peca='')
   RAISERROR('Informe o codigo da pe�a!',16,1)   
IF(@id_tipo_peca='')
   RAISERROR('Informe o codigo do tipo da pe�a!',16,1)
ELSE IF(@id_estoque='')
   RAISERROR('Informe o estoque onde est� a produto!',16,1)   
ELSE IF(@nom_peca='')
   RAISERROR('Informe o nome da pe�a!',16,1)
ELSE IF(@dsc_peca='')
   RAISERROR('Informe a descricao da pe�a!',16,1)   
ELSE IF(@qtd_minima='')
   RAISERROR('Informe a quantidade minima de estoque da pe�a!',16,1)      
ELSE

BEGIN
--Insert na tabela peca
INSERT INTO PECA(id_peca, id_tipo_peca, id_estoque, nom_peca, dsc_peca, peso, qtd_minima, dat_alt, flg_ativo)
VALUES (@id_peca, @id_tipo_peca, @id_estoque, @nom_peca, @dsc_peca, @peso, @qtd_minima, @dat_alt, @flg_ativo)
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