USE Megatechdatabase
IF OBJECT_ID('sp_update_departamento', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_departamento;
GO

CREATE PROCEDURE sp_update_departamento
@id_depto          INT,
@nom			   VARCHAR(25),
@dsc_depto         VARCHAR(30),
@dat_atl           DATETIME,
@flg_ativo         BIT
AS
BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Departamento where id_depto=@id_depto)
BEGIN
--Validacoes para a tabela Departamento

--Update na tabela departamento
UPDATE Departamento SET

nom			 = @nom,
dsc_depto    = @dsc_depto, 
dat_atl      = @dat_atl, 
flg_ativo    = @flg_ativo

WHERE id_depto = @id_depto

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Departamento inexistente!',16,1)

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