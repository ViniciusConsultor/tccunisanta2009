USE Megatechdatabase 
go
 IF OBJECT_ID('sp_busca_menu', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_busca_menu; 
 GO

CREATE PROCEDURE sp_busca_menu 
 @id_perfil INT
 AS
 SELECT m.id_menu, m.dsc_menu 'Menu', m.ende
 FROM Menu m
 INNER JOIN PerfilMenu pm 
	 ON m.id_menu = pm.id_menu
 INNER JOIN Perfil p
	 ON pm.id_perfil = p.id_perfil
 WHERE pm.id_perfil = @id_perfil
 AND m.flg_ativo = 1
go