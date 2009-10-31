USE Megatechdatabase
IF OBJECT_ID('sp_update_familiamotor', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_familiamotor;
GO

CREATE PROCEDURE sp_update_familiamotor
@id_fam_motor     INT,
@id_num_motor     INT,
@id_grupo         INT,
@id_tipo_motor    INT,
@id_motor         INT,
@id_estoque       INT,
@dsc_fam_motor    VARCHAR(500),
@flg_ativo        BIT

AS 
BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from familiamotor where id_fam_motor=@id_fam_motor)
BEGIN
--Validações na tabela falimiamotor

--Update na tabela falimiamotor
UPDATE familiamotor SET

id_num_motor    = @id_num_motor, 
id_grupo        = @id_grupo, 
id_tipo_motor   = @id_tipo_motor, 
id_motor        = @id_motor, 
id_estoque      = @id_estoque, 
dsc_fam_motor   = @dsc_fam_motor, 
flg_ativo       = @flg_ativo

WHERE id_fam_motor = @id_fam_motor

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Familia de motores inexistente!',16,1)

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