USE Megatechdatabase
IF OBJECT_ID('sp_update_cliente', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_cliente;
GO

CREATE PROCEDURE sp_update_cliente
@id_cli			 INT,
@slg_est		 VARCHAR(2),
@nom      		 VARCHAR(60),
@tel	         VARCHAR(20),
@ddd             INT,
@mail            VARCHAR(100),
@cpf			 VARCHAR(15),
@cnpj		     VARCHAR(15),
@rua	         VARCHAR(100),
@nro_ende		 INT,
@compl	         VARCHAR(20),
@cep		     INT,
@bairr		     VARCHAR(20),
@cid		     VARCHAR(50),
@dat_atl		 DATETIME,
@flg_ativo		 BIT,
@nom_est_inter	 VARCHAR(50),
@nom_pais		 VARCHAR(50)
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from cliente where id_cli=@id_cli)
BEGIN
--Validações para a tabela cliente

--Update na tabela cliente
UPDATE Cliente SET

slg_est   = @slg_est, 
nom       = @nom, 
tel       = @tel, 
ddd       = @ddd,
mail      = @mail, 
cpf       = @cpf, 
cnpj      = @cnpj, 
rua       = @rua, 
nro_ende  = @nro_ende, 
compl     = @compl, 
cep       = @cep, 
bairr     = @bairr, 
cid       = @cid, 
dat_atl   = @dat_atl, 
flg_ativo = @flg_ativo,
nom_est_inter=@nom_est_inter,
nom_pais  =@nom_pais

WHERE id_cli = @id_cli

END
ELSE
--retorna erro se não houver o codigo
RAISERROR('Cliente inexistente!',16,1)

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