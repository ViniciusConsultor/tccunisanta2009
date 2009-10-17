 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_todosMenus', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_todosMenus;
 GO
 
 CREATE PROCEDURE sp_busca_todosMenus
  AS
 SELECT id_menu, dsc_menu AS 'Descrução menu' FROM Menu
go