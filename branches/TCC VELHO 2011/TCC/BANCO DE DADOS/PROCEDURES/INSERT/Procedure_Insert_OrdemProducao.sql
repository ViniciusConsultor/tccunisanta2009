USE [Megatechdatabase]
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_peca]    Script Date: 12/11/2011 14:24:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_insert_ordemproducao]
@id_ordem_prod				INT,
@id_stat_ordem				INT,
@id_venda					INT,
@id_usu						INT
AS

BEGIN TRY
--Validações na tabela ordem produção
IF(@id_ordem_prod='')
   RAISERROR('Informe o codigo da ordem de produção!',16,1)
ELSE IF(@id_stat_ordem='')
   RAISERROR('Informe o código do status da ordem!',16,1)
ELSE IF(@id_venda='')
   RAISERROR('Informe o código da venda!',16,1)
ELSE IF(@id_usu='')
   RAISERROR('Informe o código do usuário!',16,1)
ELSE

BEGIN
--Insert na tabela peca
INSERT INTO Ordemproducao(id_ordem_prod, id_stat_ordem,id_venda, id_usu)
VALUES (@id_ordem_prod, @id_stat_ordem, @id_venda, @id_usu)
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