USE Megatechdatabase
IF OBJECT_ID('sp_insert_familiamotor', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_familiamotor;
GO

CREATE PROCEDURE sp_insert_familiamotor
@id_fam_motor	   INT,
@id_fam_motor_real VARCHAR(25),
@id_num_motor      INT,
@id_tipo_motor     INT,
@id_motor          INT,
@id_estoque        INT,
@dsc_fam_motor     VARCHAR(500),
@flg_ativo         BIT

AS 
BEGIN TRY
--Validações na tabela falimiamotor
IF(@id_num_motor='')
   RAISERROR('Informe o numero do motor!',16,1)
ELSE IF(@id_tipo_motor='')
   RAISERROR('Informe o tipo do motor!',16,1)
ELSE IF(@id_motor='')
   RAISERROR('Informe o código original do motor!',16,1)
ELSE IF(@id_estoque='')
   RAISERROR('Informe o estoque onde se encontra o motor!',16,1)
ELSE IF(@dsc_fam_motor='')
   RAISERROR('Informe o descricao do motor!',16,1)  
ELSE
BEGIN
--Insert na tabela falimiamotor
INSERT INTO FAMILIAMOTOR(id_fam_motor, id_fam_motor_real, id_num_motor, id_tipo_motor, id_motor, id_estoque, dsc_fam_motor, flg_ativo)
VALUES(@id_fam_motor, @id_fam_motor_real, @id_num_motor, @id_tipo_motor, @id_motor, @id_estoque, @dsc_fam_motor, @flg_ativo)
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