USE Megatechdatabase 
go
 IF OBJECT_ID('sp_busca_menu', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_busca_menu; 
 GO

CREATE PROCEDURE sp_busca_menu 
 @id_perfil INT
 AS
<<<<<<< .mine
 SELECT m.id_menu, m.dsc_menu 'Menu', m.ende 'Endere�o'
=======
 SELECT m.id_menu, m.dsc_menu as 'Descri��o do menu', m.end_menu as 'Endere�o do menu'
>>>>>>> .r88
 FROM Menu m
 INNER JOIN PerfilMenu pm 
	 ON m.id_menu = pm.id_menu
 INNER JOIN Perfil p
	 ON pm.id_perfil = p.id_perfil
 WHERE pm.id_perfil = @id_perfil
go