 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_todosMenus', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_todosMenus;
 GO
 
 CREATE PROCEDURE sp_busca_todosMenus
  AS
 SELECT m.id_menu, m.dsc_menu 'Menu' 
 FROM Menu m
 INNER JOIN Submenu sm
 ON m.id_menu = sm.id_menu_pai
 WHERE 
 m.id_menu NOT IN (SELECT id_menu_filho FROM submenu)
 AND flg_ativo = 1
 GROUP BY m.id_menu, m.dsc_menu