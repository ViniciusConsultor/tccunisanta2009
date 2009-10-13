USE Megatechdatabase
IF OBJECT_ID('sp_insert_fornecedor', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_fornecedor;
GO

CREATE PROCEDURE sp_insert_fornecedor
@id_fornecedor			INT,
@nom_fornecedor			VARCHAR(100),
@nom_rua_fornecedor		VARCHAR(50),
@nro_end_fornecedor		INT,
@compl_end_fornecedor	VARCHAR(20),
@cep_fornecedor			INT,
@bairr_end_fornecedor	VARCHAR(50),
@cidade_fornecedor		VARCHAR(50),
@id_cnpj_fornecedor		INT,
@dat_alt				DATETIME,
@flg_ativo				BIT,
@id_estado				INT
AS
BEGIN TRY
IF(@id_fornecedor='')
   RAISERROR('Informe o código do fornecedor!',16,1)
ELSE IF(@nom_fornecedor='')
   RAISERROR('Informe o nome do fornecedor!',16,1)
ELSE IF(@nom_rua_fornecedor='')
   RAISERROR('Informe o nome da rua do endereco do fornecedor!',16,1)
ELSE IF(@nro_end_fornecedor='')
   RAISERROR('Informe o numero do endereco do fornecedor!',16,1)
ELSE IF(@bairr_end_fornecedor='')
   RAISERROR('Informe o bairro do endereco do fornecedor!',16,1)
ELSE IF(@cidade_fornecedor='')
   RAISERROR('Informe a cidade do endereco do fornecedor!',16,1)
ELSE IF(@id_estado='')
   RAISERROR('Informe o estado do endereco do fornecedor!',16,1) 
ELSE   
BEGIN
INSERT INTO Fornecedor 
(id_fornecedor, nom_fornecedor, nom_rua_fornecedor, nro_end_fornecedor, compl_end_fornecedor, cep_fornecedor, bairr_end_fornecedor, cidade_fornecedor, id_cnpj_fornecedor, dat_alt, flg_ativo, id_estado)
VALUES 
(@id_fornecedor, @nom_fornecedor, @nom_rua_fornecedor, @nro_end_fornecedor, @compl_end_fornecedor, @cep_fornecedor, @bairr_end_fornecedor, @cidade_fornecedor, @id_cnpj_fornecedor, @dat_alt, @flg_ativo, @id_estado)
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