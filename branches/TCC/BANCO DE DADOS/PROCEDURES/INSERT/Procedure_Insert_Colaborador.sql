USE Megatechdatabase
IF OBJECT_ID('sp_insert_colaborador', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_colaborador;
GO

CREATE PROCEDURE sp_insert_colaborador
@id_colab INT,
@nom_colab VARCHAR(40),
@dat_nasc DATETIME,
@nom_rua VARCHAR(50),
@nro_end INT,
@compl_end VARCHAR(20),
@cep VARCHAR(10),
@bairr_end VARCHAR(30),
@cidade VARCHAR(40),
@rg VARCHAR(15),
@cpf VARCHAR(15),
@sexo CHAR(1),
@dat_atl DATETIME,
@flg_ativo BIT,
@id_usu INT,
@id_depto INT,
@id_estado INT
AS

BEGIN TRY
IF (@id_colab='')
   RAISERROR('Informe o código do colaborador!',16,1)
ELSE IF(@nom_colab='')
   RAISERROR('Informe o nome do colaborador!',16,1)
ELSE IF(@dat_nasc='')
   RAISERROR('Informe a data de nascimento do colaborador!',16,1)
ELSE IF(@nom_rua='')
   RAISERROR('Informe o nome da rua do endereco do colaborador!',16,1)
ELSE IF(@nro_end='')
   RAISERROR('Informe o numero do endereco do colaborador!',16,1)
ELSE IF(@bairr_end='')
   RAISERROR('Informe o bairro do endereco do colaborador!',16,1)
ELSE IF(@cidade='')
   RAISERROR('Informe a cidade do endereco do colaborador!',16,1)
ELSE IF(@sexo='')
   RAISERROR('Informe o sexo do colaborador!',16,1)
ELSE IF(@id_depto='')
   RAISERROR('Informe o departamento do colaborador!',16,1)
ELSE
BEGIN
INSERT INTO 
Colaborador(id_colab, nom_colab, dat_nasc, nom_rua, nro_end, compl_end, cep, bairr_end, cidade, rg, cpf, sexo, dat_atl, flg_ativo, id_usu, id_depto, id_estado)
VALUES
(@id_colab, @nom_colab, @dat_nasc, @nom_rua, @nro_end, @compl_end, @cep, @bairr_end, @cidade, @rg, @cpf, @sexo, @dat_atl, @flg_ativo, @id_usu, @id_depto, @id_estado)
END
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