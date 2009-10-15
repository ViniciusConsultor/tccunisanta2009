USE Megatechdatabase
IF OBJECT_ID('sp_insert_kitgrupopeca', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_kitgrupopeca;
GO

CREATE PROCEDURE sp_insert_kitgrupopeca
@id_grupo      INT,
@id_peca       VARCHAR(20),
@id_item_peca  INT,
@nom_grupo     VARCHAR(50),
@flg_ativo     BIT

AS 
BEGIN TRY
--Validações na tabela kitgrupopeca
IF(@id_grupo='')
   RAISERROR('Informe o código do grupo de peças!',16,1)
ELSE IF(@id_peca='')
   RAISERROR('Informe o codigo da peça!',16,1)
ELSE IF(@id_item_peca='')
   RAISERROR('Informe o codigo do item da peça!',16,1)
ELSE IF(@nom_grupo='')
   RAISERROR('Informe o nome do grupo de peças!',16,1)   
ELSE

BEGIN
--Insert na tabela itempeca
INSERT INTO KITGRUPOPECA(id_grupo, id_peca, id_item_peca, nom_grupo, flg_ativo)
VALUES(@id_grupo, @id_peca, @id_item_peca, @nom_grupo, @flg_ativo)
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