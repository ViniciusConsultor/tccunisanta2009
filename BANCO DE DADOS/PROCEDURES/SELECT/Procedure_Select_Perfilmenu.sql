USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_perfilmenu','p') IS NOT NULL
		DROP PROCEDURE sp_select_perfilmenu;
GO

CREATE PROCEDURE sp_select_perfilmenu
@id_perfil INT,
@id_menu INT
AS
SELECT id_perfil, dat_alt, flg_ativo, id_menu
FROM Perfilmenu
WHERE id_perfil = @id_perfil and id_menu = @id_menu