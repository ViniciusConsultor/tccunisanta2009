USE Megatechdatabase
IF OBJECT_ID('sp_update_fornecedor', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_fornecedor;
GO

CREATE PROCEDURE sp_update_fornecedor
@id_forn			INT,
@slg_est			VARCHAR(2),
@nom			    VARCHAR(100),
@DDD                INT,
@tel                INT,
@mail               VARCHAR(100),
@rua		        VARCHAR(50),
@nro_ende		    INT,
@compl              VARCHAR(20),
@cep			    INT,
@bairr              VARCHAR(50),
@cid		        VARCHAR(50),
@cnpj		        VARCHAR(15),
@dat_alt			DATETIME,
@flg_ativo			BIT,
@nom_est_inter		VARCHAR(50),
@nom_pais			VARCHAR(50)

AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Fornecedor where id_forn=@id_forn)
BEGIN
--Valida��es na tabela fornecedor
  
--Update na tabela fornecedor
UPDATE Fornecedor SET

slg_est    = @slg_est, 
nom        = @nom, 
rua        = @rua, 
DDD        = @DDD,
tel        = @tel,
mail       = @mail,
nro_ende   = @nro_ende, 
compl      = @compl, 
cep        = @cep, 
bairr      = @bairr, 
cid        = @cid, 
cnpj       = @cnpj, 
dat_alt    = @dat_alt, 
flg_ativo  = @flg_ativo,
nom_est_inter=@nom_est_inter,
nom_pais=@nom_pais

WHERE id_forn = @id_forn

END
ELSE
--retorna erro se n�o houver o codigo
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