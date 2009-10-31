USE Megatechdatabase
IF OBJECT_ID('sp_insert_cliente', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_cliente;
GO

CREATE PROCEDURE sp_insert_cliente
@id_cli			INT,
@nom		VARCHAR(60),
@tel	    INT,
@rua	    VARCHAR(100),
@nro_ende		INT,
@compl	    VARCHAR(20),
@cep		    INT,
@bairr		VARCHAR(20),
@cid		    VARCHAR(50),
@cpf	    VARCHAR(15),
@cnpj	    VARCHAR(15),
@dat_atl		DATETIME,
@flg_ativo		BIT,
@slg_est		VARCHAR(2),
@mail  VARCHAR(100),
@ddd    INT
AS

BEGIN TRY
--Validações para a tabela cliente
IF(@id_cli='')
  RAISERROR('Informe o código do cliente!',16,1)
ELSE IF(@slg_est='')
  RAISERROR('Informe o estado do cliente!',16,1)
ELSE IF(@nom='')
  RAISERROR('Informe o nome do cliente!',16,1)
ELSE IF(@mail='')
  RAISERROR('Informe o e-mail do cliente!',16,1)
ELSE IF(@rua='')
  RAISERROR('Informe a rua do endereco do cliente!',16,1)
ELSE IF(@nro_ende='')
  RAISERROR('Informe o numero do cliente!',16,1)
ELSE IF(@bairr='')
  RAISERROR('Informe o bairro do cliente!',16,1)
ELSE IF(@cid='')
  RAISERROR('Informe o cidade do cliente!',16,1)
ELSE
BEGIN
--Insert na tabela cliente
INSERT INTO Cliente
(id_cli, slg_est, nom, tel, ddd, mail, cnpj, cpf, rua, nro_ende, compl, cep, bairr, cid, dat_atl, flg_ativo)
VALUES
(@id_cli, @slg_est, @nom, @tel, @ddd, @mail, @cnpj, @cpf, @rua, @nro_ende, @compl, @cep, @bairr, @cid, @dat_atl, @flg_ativo)
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