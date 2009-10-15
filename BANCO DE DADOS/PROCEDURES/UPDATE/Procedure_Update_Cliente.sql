USE Megatechdatabase
IF OBJECT_ID('sp_update_cliente', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_cliente;
GO

CREATE PROCEDURE sp_update_cliente
@id_cli			 INT,
@slg_estado		 VARCHAR(2),
@nom_cli		 VARCHAR(60),
@tel_cli	     VARCHAR(20),
@ddd_cliente     INT,
@email_cliente   VARCHAR(100),
@id_rg			 INT,
@id_cnpj		 INT,
@nom_rua	     VARCHAR(100),
@num_end		 INT,
@compl_end	     VARCHAR(20),
@cep		     INT,
@bairr_end		 VARCHAR(20),
@cidade		     VARCHAR(50),
@dat_atl		 DATETIME,
@flg_ativo		 BIT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from cliente where id_cli=@id_cli)
BEGIN
--Validações para a tabela cliente

--Update na tabela cliente
UPDATE Cliente SET

slg_estado    = @slg_estado, 
nom_cli       = @nom_cli, 
tel_cli       = @tel_cli, 
ddd_cliente   = @ddd_cliente,
email_cliente = @email_cliente, 
id_rg         = @id_rg, 
id_cnpj       = @id_cnpj, 
nom_rua       = @nom_rua, 
num_end       = @num_end, 
compl_end     = @compl_end, 
cep           = @cep, 
bairr_end     = @bairr_end, 
cidade        = @cidade, 
dat_atl       = @dat_atl, 
flg_ativo     = @flg_ativo

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