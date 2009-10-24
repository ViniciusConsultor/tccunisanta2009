USE Megatechdatabase
go

IF OBJECT_ID('sp_busca_subMenu','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_subMenu;
GO

CREATE PROCEDURE sp_busca_subMenu
@id_menu_pai INT
AS
SELECT id_menu_filho 'id_menu', m.dsc_menu, m.ende FROM Submenu sm
INNER JOIN Menu m
ON sm.id_menu_filho = m.id_menu
WHERE id_menu_pai = @id_menu_pai