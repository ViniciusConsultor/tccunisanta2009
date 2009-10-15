USE Megatechdatabase
IF OBJECT_ID('sp_insert_colaborador', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_colaborador;
GO

CREATE PROCEDURE sp_insert_colaborador
@id_colab    INT,
@id_usu      INT,
@id_depto    INT,
@slg_estado  VARCHAR(2),
@nom_colab   VARCHAR(40),
@dat_nasc    DATETIME,
@tel_colab   INT,
@ddd_colab   INT,
@email_colab VARCHAR(100),
@nom_rua     VARCHAR(50),
@nro_end     INT,
@compl_end   VARCHAR(20),
@cep         VARCHAR(10),
@bairr_end   VARCHAR(30),
@cidade      VARCHAR(40),
@rg          VARCHAR(15),
@cpf         VARCHAR(15),
@sexo        CHAR(1),
@dat_atl     DATETIME,
@flg_ativo   BIT
AS

BEGIN TRY
--Validações para a tabela colaborador
IF (@id_colab='')
   RAISERROR('Informe o código do colaborador!',16,1)
ELSE IF(@id_depto='')
   RAISERROR('Informe o departamento do colaborador!',16,1)
ELSE IF(@nom_colab='')
   RAISERROR('Informe o nome do colaborador!',16,1)
ELSE IF(@dat_nasc='')
   RAISERROR('Informe a data de nascimento do colaborador!',16,1)
ELSE IF(@nom_rua='')
   RAISERROR('Informe a rua do endereco do colaborador!',16,1)
ELSE IF(@nro_end='')
   RAISERROR('Informe o numero do endereco do colaborador!',16,1)
ELSE IF(@bairr_end='')
   RAISERROR('Informe o bairro do endereco do colaborador!',16,1)
ELSE IF(@cidade='')
   RAISERROR('Informe a cidade do endereco do colaborador!',16,1)
ELSE IF(@sexo='')
   RAISERROR('Informe o sexo do colaborador!',16,1)
ELSE
BEGIN
--Insert na tabela colaborador
INSERT INTO 
Colaborador(id_colab, id_usu, id_depto, slg_estado, nom_colab, dat_nasc, tel_colab, ddd_colab, email_colab, nom_rua, nro_end, compl_end, cep, bairr_end, cidade, rg, cpf, sexo, dat_atl, flg_ativo)
VALUES
(@id_colab, @id_usu, @id_depto, @slg_estado, @nom_colab, @dat_nasc, @tel_colab, @ddd_colab, @email_colab, @nom_rua, @nro_end, @compl_end, @cep, @bairr_end, @cidade, @rg, @cpf, @sexo, @dat_atl, @flg_ativo)
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