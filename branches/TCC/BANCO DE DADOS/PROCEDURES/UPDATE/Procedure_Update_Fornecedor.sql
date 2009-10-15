USE Megatechdatabase
IF OBJECT_ID('sp_update_fornecedor', 'P')IS NOT NULL
	DROP PROCEDURE sp_update_fornecedor;
GO

CREATE PROCEDURE sp_update_fornecedor
@id_fornecedor			INT,
@slg_estado				VARCHAR(2),
@nom_fornecedor			VARCHAR(100),
@DDD                    INT,
@tel_fornecedor         INT,
@Email                  VARCHAR(100),
@nom_rua_fornecedor		VARCHAR(50),
@nro_end_fornecedor		INT,
@compl_end_fornecedor   VARCHAR(20),
@cep_fornecedor			INT,
@bairr_end_fornecedor   VARCHAR(50),
@cidade_fornecedor		VARCHAR(50),
@id_cnpj_fornecedor		INT,
@dat_alt				DATETIME,
@flg_ativo				BIT
AS

BEGIN TRY
--verifica a exitencia do codigo recebido
IF EXISTS(select 1 from Fornecedor where id_fornecedor=@id_fornecedor)
BEGIN
--Validações na tabela fornecedor
  
--Update na tabela fornecedor
UPDATE Fornecedor SET

slg_estado            = @slg_estado, 
nom_fornecedor        = @nom_fornecedor, 
nom_rua_fornecedor    = @nom_rua_fornecedor, 
DDD                   = @DDD,
tel_fornecedor        = @tel_fornecedor,
Email                 = @Email,
nro_end_fornecedor    = @nro_end_fornecedor, 
compl_end_fornecedor  = @compl_end_fornecedor, 
cep_fornecedor        = @cep_fornecedor, 
bairr_end_fornecedor  = @bairr_end_fornecedor, 
cidade_fornecedor     = @cidade_fornecedor, 
id_cnpj_fornecedor    = @id_cnpj_fornecedor, 
dat_alt               = @dat_alt, 
flg_ativo             = @flg_ativo

WHERE id_fornecedor = @id_fornecedor

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