USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_perfilmenu','p') IS NOT NULL
		DROP PROCEDURE sp_select_perfilmenu;
GO

CREATE PROCEDURE sp_select_perfilmenu
@id_perfil INT,
@id_menu INT
AS
SELECT id_perfil, dat_alt, id_menu, flg_ativo
FROM Perfilmenu
WHERE id_perfil = @id_perfil and id_menu = @id_menu
AND flg_ativo = 1