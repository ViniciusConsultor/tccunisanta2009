USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_usuarioperfil','p') IS NOT NULL
		DROP PROCEDURE sp_select_usuarioperfil;
GO

CREATE PROCEDURE sp_select_usuarioperfil
@id_usu INT,
@id_perfil INT
AS
SELECT id_usu, id_perfil, flg_ativo, dat_alt
FROM Usuarioperfil
WHERE id_usu = @id_usu and id_perfil = @id_perfil