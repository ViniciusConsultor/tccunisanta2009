USE Megatechdatabase
IF OBJECT_ID('sp_insert_peca', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_peca;
GO

CREATE PROCEDURE sp_insert_peca
@id_peca_real         VARCHAR(50),
@id_tipo_peca         INT,
@nom                  VARCHAR(50),
@dsc_peca             VARCHAR(100),
@peso                 DECIMAL(10,2),
@qtd_min              INT,
@dat_alt              DATETIME,
@flg_ativo            BIT
AS

BEGIN TRY
--Validações na tabela peca  
IF(@id_tipo_peca='')
   RAISERROR('Informe o codigo do tipo da peça!',16,1)
ELSE IF(@nom='')
   RAISERROR('Informe o nome da peça!',16,1)
ELSE IF(@dsc_peca='')
   RAISERROR('Informe a descricao da peça!',16,1)   
ELSE IF(@qtd_min='')
   RAISERROR('Informe a quantidade minima de estoque da peça!',16,1)      
ELSE

BEGIN
--Insert na tabela peca
INSERT INTO PECA(id_peca_real,id_tipo_peca, nom, dsc_peca, peso, qtd_min, dat_alt, flg_ativo)
VALUES (@id_peca_real, @id_tipo_peca, @nom, @dsc_peca, @peso, @qtd_min, @dat_alt, @flg_ativo)
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