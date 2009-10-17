 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_menusParam', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_menusParam;
 GO

 CREATE PROCEDURE sp_busca_menusParam
 @param VARCHAR(50)
 AS
<<<<<<< .mine
 SELECT id_menu, dsc_menu 'Menu' FROM Menu WHERE dsc_menu like @param + '%'
=======
 SELECT id_menu, dsc_menu  as 'Descrição do menu' FROM Menu WHERE dsc_menu like @param + '%'
>>>>>>> .r88
go