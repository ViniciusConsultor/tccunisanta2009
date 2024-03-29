USE Megatechdatabase
IF OBJECT_ID('sp_insert_fornecedor', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_fornecedor;
GO

CREATE PROCEDURE sp_insert_fornecedor
@id_forn				INT,
@nom			        VARCHAR(100),
@rua		            VARCHAR(50),
@nro_ende		        INT,
@compl                  VARCHAR(20),
@cod_post		        VARCHAR(20),
@ddd                    INT,
@bairr                  VARCHAR(50),
@tel                    INT,
@cid		            VARCHAR(50),
@mail                   VARCHAR(100),
@cnpj		            VARCHAR(15),
@dat_alt				DATETIME,
@flg_ativo				BIT,
@slg_est				VARCHAR(2),
@nom_pais				VARCHAR(50),
@nom_est_inter			VARCHAR(50),
@ddi					CHAR(4),
@ident_inter			VARCHAR(50)
AS

BEGIN TRY
--Validações na tabela fornecedor
IF(@slg_est='')
   RAISERROR('Informe o estado do fornecedor!',16,1) 
ELSE IF(@nom='')
   RAISERROR('Informe o nome do fornecedor!',16,1)
ELSE IF(@cid='')
   RAISERROR('Informe a cidade do fornecedor!',16,1)
ELSE 
  
BEGIN
--Insert na tabela fornecedor
INSERT INTO Fornecedor(id_forn, slg_est, nom, tel, ddd, mail, rua, nro_ende, compl, cod_post, bairr, cid, cnpj, dat_alt, flg_ativo,nom_pais,nom_est_inter,ddi,ident_inter)
VALUES(@id_forn, @slg_est, @nom, @tel, @ddd, @mail, @rua, @nro_ende, @compl, @cod_post, @bairr, @cid, @cnpj, @dat_alt, @flg_ativo,@nom_pais, @nom_est_inter, @ddi, @ident_inter)
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