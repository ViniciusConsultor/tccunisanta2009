 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_perfilmenu_param', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_perfilmenu_param;
 GO

 CREATE PROCEDURE sp_busca_perfilmenu_param
 @id_perfil AS VARCHAR(50)
 AS
 SELECT id_perfil, dat_alt, flg_ativo, id_menu
 FROM PerfilMenu
 WHERE id_perfil = @id_perfil
 AND flg_ativo = 1