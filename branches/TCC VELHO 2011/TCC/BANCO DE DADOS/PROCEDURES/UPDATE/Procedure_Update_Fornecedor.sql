USE Megatechdatabase
IF OBJECT_ID('sp_update_fornecedor', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_fornecedor;
GO

CREATE PROCEDURE sp_update_fornecedor
@id_forn			INT,
@nom			    VARCHAR(100),
@rua		        VARCHAR(50),
@nro_ende		    INT,
@compl              VARCHAR(20),
@cod_post		    VARCHAR(20),
@ddd                INT,
@bairr              VARCHAR(50),
@tel                INT,
@cid		        VARCHAR(50),
@mail               VARCHAR(100),
@cnpj		        VARCHAR(15),
@dat_alt			DATETIME,
@flg_ativo			BIT,
@slg_est			VARCHAR(2),
@nom_pais			VARCHAR(50),
@nom_est_inter		VARCHAR(50),
@ddi				char(4),
@ident_inter		VARCHAR(50)

AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Fornecedor where id_forn=@id_forn)
BEGIN
--Validações na tabela fornecedor
  
--Update na tabela fornecedor
UPDATE Fornecedor SET

nom        = @nom,
rua        = @rua, 
nro_ende   = @nro_ende, 
compl      = @compl, 
cod_post   = @cod_post,
ddd        = @ddd,
bairr      = @bairr, 
tel        = @tel,
cid        = @cid, 
mail       = @mail,
cnpj       = @cnpj, 
dat_alt    = @dat_alt, 
flg_ativo  = @flg_ativo,
slg_est    = @slg_est,  
nom_pais   = @nom_pais,
nom_est_inter=@nom_est_inter,
ddi		   = @ddi,
ident_inter=@ident_inter


WHERE id_forn = @id_forn

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Fornecedor inexistente!',16,1)

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