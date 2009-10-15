USE Megatechdatabase
IF OBJECT_ID('sp_update_fornecedordepto', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_fornecedordepto;
GO

CREATE PROCEDURE sp_update_fornecedordepto
@id_depto              INT,
@id_fornecedor         INT,
@dat_alt               DATETIME,
@flg_ativo             BIT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Fornecedordepto where id_depto=@id_depto AND id_fornecedor = @id_fornecedor)
BEGIN
--Validações para a tabela comprapeca

--Update na tabela comprapeca
UPDATE Fornecedordepto SET

dat_alt                = @dat_alt,
flg_ativo              = @flg_ativo

WHERE id_depto = @id_depto AND id_fornecedor = @id_fornecedor

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Fornecedor inexistente neste departamento!',16,1)

END TRY

BEGIN CATCH
DECLARE @ErrorMessage NVARCHAR(4000);
DECLARE @ErrorSeverity INT;
DECLARE @ErrorState INT;
SELECT
@ErrorMessage=ERROR_MESSAGE(),
@ErrorSeverity=ERROR_SEVERITY(),
@ErrorState=ERROR_STATE();
--Use RAISERROR inside the CATCH block to return error
--information about the original error that caused
--execution to jump to the CATCH block.
RAISERROR(
@ErrorMessage, --Message text
@ErrorSeverity, --Severity
@ErrorState --State
);
END CATCH;