USE Megatechdatabase
go
IF OBJECT_ID('sp_busca_maxId', 'P')IS NOT NULL
	DROP PROCEDURE sp_busca_maxId;
GO

CREATE PROCEDURE sp_busca_maxId
@nome_tabela AS VARCHAR(200),
@campo_tabela AS VARCHAR(100)
AS
DECLARE @SSQL AS VARCHAR(500) 
set @SSQL = 'SELECT MAX(' + @campo_tabela + ') as max FROM ' + @nome_tabela
execute(@SSQL)