 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_insert_cliente', 'P')IS NOT NULL
	 DROP PROCEDURE sp_insert_cliente
 GO
 
 CREATE PROCEDURE sp_insert_cliente
 @id_cli			INT,
 @nom_cli		VARCHAR(60),
 @tel_cli		VARCHAR(20),
 @nom_rua		VARCHAR(100),
 @id_estado		INT,
 @num_end		INT,
 @compl_end		VARCHAR(20),
 @cep			INT,
 @bairr_end		VARCHAR(20),
 @cidade			VARCHAR (50),
 @id_rg			INT,
 @id_cnpj		INT,
 @dat_atl		DATETIME,
 @flg_ativo		BIT
 AS
 
 BEGIN TRY
 IF(@id_cli='')
   RAISERROR('Informe o código do cliente!',16,1)
 ELSE IF(@nom_cli='')
   RAISERROR('Informe o nome do cliente!',16,1)
 ELSE IF(@nom_rua='')
   RAISERROR('Informe o nome da rua do endereco do cliente!',16,1)
 ELSE IF(@id_estado='')
   RAISERROR('Informe o estado do endereco do cliente!',16,1)
 ELSE IF(@num_end='')
   RAISERROR('Informe o numero do endereco do cliente!',16,1)
 ELSE IF(@bairr_end='')
   RAISERROR('Informe o bairro do endereco do cliente!',16,1)
 ELSE IF(@cidade='')
   RAISERROR('Informe o cidade do endereco do cliente!',16,1)
 ELSE
 BEGIN
 INSERT INTO Cliente
 (id_cli, nom_cli, tel_cli, nom_rua, id_estado, num_end, compl_end, cep, bairr_end, cidade, id_rg, id_cnpj, dat_atl, flg_ativo)
 VALUES
 (@id_cli, @nom_cli, @tel_cli, @nom_rua, @id_estado, @num_end, @compl_end, @cep, @bairr_end, @cidade, @id_rg, @id_cnpj, @dat_atl, @flg_ativo)
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
 )
 END CATCH
go