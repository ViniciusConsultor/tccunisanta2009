USE Megatechdatabase
IF OBJECT_ID('sp_insert_fornecedor', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_fornecedor;
GO

CREATE PROCEDURE sp_insert_fornecedor
@id_forn			    INT,
@nom			        VARCHAR(100),
@rua		            VARCHAR(50),
@nro_ende		        INT,
@compl                  VARCHAR(20),
@cep			        INT,
@ddd                    INT,
@bairr                  VARCHAR(50),
@tel                    INT,
@cid		            VARCHAR(50),
@mail                  VARCHAR(100),
@cnpj		            VARCHAR(15),
@dat_alt				DATETIME,
@flg_ativo				BIT,
@slg_est				VARCHAR(2)
AS

BEGIN TRY
--Validações na tabela fornecedor
IF(@id_forn='')
   RAISERROR('Informe o código do fornecedor!',16,1)
ELSE IF(@slg_est='')
   RAISERROR('Informe o estado do fornecedor!',16,1) 
ELSE IF(@nom='')
   RAISERROR('Informe o nome do fornecedor!',16,1)
ELSE IF(@rua='')
   RAISERROR('Informe a rua do endereco do fornecedor!',16,1)
ELSE IF(@nro_ende='')
   RAISERROR('Informe o número do endereco do fornecedor!',16,1)
ELSE IF(@bairr='')
   RAISERROR('Informe o bairro do fornecedor!',16,1)
ELSE IF(@cid='')
   RAISERROR('Informe a cidade do fornecedor!',16,1)
ELSE IF(@ddd='')
   RAISERROR('Informe o nº de ddd do fornecedor!',16,1)   
ELSE IF(@tel='')
   RAISERROR('Informe o nº de telefone do fornecedor!',16,1)   
ELSE IF(@mail='')
   RAISERROR('Informe o e-mail do fornecedor!',16,1)   
ELSE IF(@cnpj='')
   RAISERROR('Informe o nº de CNPJ do fornecedor!',16,1)   
ELSE 
  
BEGIN
--Insert na tabela fornecedor
INSERT INTO Fornecedor(id_forn, slg_est, nom, tel, ddd, mail, rua, nro_ende, compl, cep, bairr, cid, cnpj, dat_alt, flg_ativo)
VALUES(@id_forn, @slg_est, @nom, @tel, @ddd, @mail, @rua, @nro_ende, @compl, @cep, @bairr, @cid, @cnpj, @dat_alt, @flg_ativo)
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