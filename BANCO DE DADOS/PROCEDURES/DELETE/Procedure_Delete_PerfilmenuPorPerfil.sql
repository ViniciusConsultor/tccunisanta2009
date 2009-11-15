USE Megatechdatabase
IF OBJECT_ID('sp_delete_perfilmenuporperfil', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_perfilmenuporperfil;
GO

CREATE PROCEDURE sp_delete_perfilmenuporperfil
@id_perfil    	INT
AS
DELETE perfilmenu
WHERE id_perfil = @id_perfil
