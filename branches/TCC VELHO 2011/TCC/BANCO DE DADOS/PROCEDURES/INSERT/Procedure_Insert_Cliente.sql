USE Megatechdatabase
IF OBJECT_ID('sp_insert_cliente', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_cliente;
GO

CREATE PROCEDURE sp_insert_cliente
@id_cli		INT,
@nom		VARCHAR(60),
@tel	    INT,
@rua	    VARCHAR(100),
@nro_ende	INT,
@compl	    VARCHAR(20),
@cod_post	VARCHAR(20),
@bairr		VARCHAR(20),
@cid		VARCHAR(50),
@cpf	    VARCHAR(15),
@dat_atl	DATETIME,
@flg_ativo	BIT,
@mail		VARCHAR(100),
@ddd		INT,
@cnpj		NUMERIC(15,0),
@nom_est_inter VARCHAR(50),
@nom_pais	VARCHAR (50),
@slg_est	VARCHAR(2),
@ident_inter VARCHAR(50),
@ddi		char(4)

AS

BEGIN TRY
--Validações para a tabela cliente
IF(@slg_est='')
  RAISERROR('Informe o estado do cliente!',16,1)
ELSE IF(@nom='')
  RAISERROR('Informe o nome do cliente!',16,1)
ELSE IF(@mail='')
  RAISERROR('Informe o e-mail do cliente!',16,1)
ELSE IF(@cid='')
  RAISERROR('Informe o cidade do cliente!',16,1)
ELSE
BEGIN
--Insert na tabela cliente
INSERT INTO Cliente
(id_cli, nom, tel, rua, nro_ende, compl, cod_post, bairr, cid, cpf, dat_atl, flg_ativo, mail, ddd, cnpj, nom_est_inter, nom_pais, slg_est, ident_inter, ddi)
VALUES
(@id_cli, @nom, @tel, @rua, @nro_ende, @compl, @cod_post, @bairr, @cid, @cpf, @dat_atl, @flg_ativo, @mail, @ddd, @cnpj, @nom_est_inter, @nom_pais, @slg_est, @ident_inter, @ddi)
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