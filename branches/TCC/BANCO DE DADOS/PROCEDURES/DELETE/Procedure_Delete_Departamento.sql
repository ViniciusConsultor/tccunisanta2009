USE Megatechdatabase
IF OBJECT_ID('sp_delete_departamento', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_departamento;
GO

CREATE PROCEDURE sp_delete_departamento
@id_depto	INT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from departamento where id_depto=@id_depto)
BEGIN
  --deleta logicamente dependencias existentes
  IF EXISTS(select 1 from fornecedordepto where id_depto=@id_depto)
	BEGIN
		UPDATE fornecedordepto SET flg_ativo = 0
		WHERE id_depto=@id_depto
	END
  IF EXISTS(select 1 from estoque where id_depto=@id_depto)
	BEGIN
		UPDATE estoque SET flg_ativo = 0
		WHERE id_depto=@id_depto
	END	
--realiza a exclusao logicamente
UPDATE Departamento SET flg_ativo = 0
WHERE id_depto=@id_depto

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