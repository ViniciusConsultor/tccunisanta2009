USE Megatechdatabase
IF OBJECT_ID('sp_update_colaborador', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_colaborador;
GO

CREATE PROCEDURE sp_update_colaborador
@id_colab         INT,
@id_usu           INT,
@id_depto         INT,
@slg_est          VARCHAR(2),
@nom              VARCHAR(40),
@ddd              INT,
@tel              INT,
@mail             VARCHAR(100),
@dat_nasc         DATETIME,
@rua              VARCHAR(50),
@nro_ende         INT,
@compl            VARCHAR(20),
@cep              VARCHAR(10),
@bairr            VARCHAR(30),
@cid              VARCHAR(40),
@rg               VARCHAR(15),
@cpf              VARCHAR(15),
@sex              CHAR(1),
@dat_atl          DATETIME,
@flg_ativo        BIT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Colaborador where id_colab=@id_colab)
BEGIN
--Validações para a tabela colaborador

--Update na tabela colaborador
UPDATE Colaborador SET

id_usu     = @id_usu, 
slg_est    = @slg_est, 
id_depto   = @id_depto,
nom        = @nom, 
ddd        = @ddd,
tel        = @tel,
mail       = @mail,
dat_nasc   = @dat_nasc, 
rua        = @rua, 
nro_ende   = @nro_ende, 
compl      = @compl, 
cep        = @cep, 
bairr      = @bairr, 
cid        = @cid, 
rg         = @rg, 
cpf        = @cpf, 
sex        = @sex, 
dat_atl    = @dat_atl, 
flg_ativo  = @flg_ativo

WHERE id_colab = @id_colab

END
ELSE
--retorna erro se não houver o codigo
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