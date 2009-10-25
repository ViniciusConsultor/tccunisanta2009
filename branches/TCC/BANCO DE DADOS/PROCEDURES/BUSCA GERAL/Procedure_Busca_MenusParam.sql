 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_menus_param', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_menus_param;
 GO

 CREATE PROCEDURE sp_busca_menus_param
 @param VARCHAR(50)
 AS
 SELECT m.id_menu, m.dsc_menu 'Menu' FROM Menu m
INNER JOIN Submenu sm
 ON m.id_menu = sm.id_menu_pai
 WHERE 
 m.dsc_menu like @param + '%'
 AND m.id_menu NOT IN (SELECT id_menu_filho FROM submenu)
 GROUP BY m.id_menu, m.dsc_menu
go