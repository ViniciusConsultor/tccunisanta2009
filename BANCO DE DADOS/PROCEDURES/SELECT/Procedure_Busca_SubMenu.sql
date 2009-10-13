 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_submenu', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_submenu;
 GO
 
 CREATE PROCEDURE sp_busca_submenu
 @id_menu AS INT,
 @id_perfil AS INT
 AS
 SELECT sm.id_sub, sm.dsc_sub, sm.end_sub
 FROM Submenu sm
 INNER JOIN Menusubmenu msm
	 ON sm.id_sub = msm.id_sub
 INNER JOIN Menu m
	 ON msm.id_menu = m.id_menu
 INNER JOIN Perfilmenu pm
	 ON m.id_menu = pm.id_menu
 INNER JOIN Perfil p
	 ON pm.id_perfil = p.id_perfil
 WHERE p.id_perfil = @id_perfil
 AND m.id_menu = @id_menu
go