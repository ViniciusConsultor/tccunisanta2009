 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_menusParam', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_menusParam;
 GO

 CREATE PROCEDURE sp_busca_menusParam
 @param VARCHAR(50)
 AS
 SELECT id_menu, dsc_menu FROM Menu WHERE dsc_menu like @param + '%'
go