USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_menu','p') IS NOT NULL
		DROP PROCEDURE sp_select_menu;
GO

CREATE PROCEDURE sp_select_menu
@id_menu INT
AS
SELECT id_menu, dsc_menu, ende, dat_atl
FROM Menu
WHERE id_menu = @id_menu
AND flg_ativo = 1