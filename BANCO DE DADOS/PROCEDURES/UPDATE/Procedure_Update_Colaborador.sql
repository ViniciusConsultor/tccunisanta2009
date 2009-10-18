USE Megatechdatabase
IF OBJECT_ID('sp_update_colaborador', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_colaborador;
GO

CREATE PROCEDURE sp_update_colaborador
@id_colab         INT,
@id_usu           INT,
@slg_estado       VARCHAR(2),
@nom_colab        VARCHAR(40),
@ddd_colab        INT,
@tel_colab        INT,
@email_colab      VARCHAR(100),
@dat_nasc         DATETIME,
@nom_rua          VARCHAR(50),
@nro_end          INT,
@compl_end        VARCHAR(20),
@cep              VARCHAR(10),
@bairr_end        VARCHAR(30),
@cidade           VARCHAR(40),
@rg               VARCHAR(15),
@cpf              VARCHAR(15),
@sexo             CHAR(1),
@dat_atl          DATETIME,
@flg_ativo        BIT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Colaborador where id_colab=@id_colab)
BEGIN
--Valida��es para a tabela colaborador

--Update na tabela colaborador
UPDATE Colaborador SET

id_usu           = @id_usu, 
slg_estado       = @slg_estado, 
nom_colab        = @nom_colab, 
ddd_colab        = @ddd_colab,
tel_colab        = @tel_colab,
email_colab      = @email_colab,
dat_nasc         = @dat_nasc, 
nom_rua          = @nom_rua, 
nro_end          = @nro_end, 
compl_end        = @compl_end, 
cep              = @cep, 
bairr_end        = @bairr_end, 
cidade           = @cidade, 
rg               = @rg, 
cpf              = @cpf, 
sexo             = @sexo, 
dat_atl          = @dat_atl, 
flg_ativo        = @flg_ativo

WHERE id_colab = @id_colab

END
ELSE
--retorna erro se n�o houver o codigo
RAISERROR('Colaborador inexistente!',16,1)

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