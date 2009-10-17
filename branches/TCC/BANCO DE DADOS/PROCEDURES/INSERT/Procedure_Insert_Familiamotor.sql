USE Megatechdatabase
IF OBJECT_ID('sp_insert_familiamotor', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_familiamotor;
GO

CREATE PROCEDURE sp_insert_familiamotor
@id_motor         INT,
@id_num_motor     INT,
@id_grupo         INT,
@id_tipo_motor    VARCHAR(20),
@id_motor_compra  INT,
@id_estoque       INT,
@dsc_motor        VARCHAR(500),
@flg_ativo        BIT

AS 
BEGIN TRY
--Valida��es na tabela falimiamotor
IF(@id_motor='')
   RAISERROR('Informe o c�digo do motor!',16,1)
ELSE IF(@id_num_motor='')
   RAISERROR('Informe o numero do motor!',16,1)
ELSE IF(@id_grupo='')
   RAISERROR('Informe o grupo do motor!',16,1)
ELSE IF(@id_tipo_motor='')
   RAISERROR('Informe o tipo do motor!',16,1)
ELSE IF(@id_motor_compra='')
   RAISERROR('Informe o c�digo original do motor!',16,1)
ELSE IF(@id_estoque='')
   RAISERROR('Informe o estoque onde se encontra o motor!',16,1)
ELSE IF(@dsc_motor='')
   RAISERROR('Informe o descricao do motor!',16,1)  
ELSE
BEGIN
--Insert na tabela falimiamotor
INSERT INTO FAMILIAMOTOR(id_motor, id_num_motor, id_grupo, id_tipo_motor, id_motor_compra, id_estoque, dsc_motor, flg_ativo)
VALUES(@id_motor, @id_num_motor, @id_grupo, @id_tipo_motor, @id_motor_compra, @id_estoque, @dsc_motor, @flg_ativo)
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