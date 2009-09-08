USE Megatechdatabase
go

CREATE PROCEDURE sp_busca_menu
@id_perfil INT
AS
SELECT m.id_menu, m.dsc_menu, m.end_menu 
FROM Menu m
INNER JOIN PerfilMenu pm 
	ON m.id_menu = pm.id_menu
INNER JOIN Perfil p
	ON pm.id_perfil = p.id_perfil
WHERE pm.id_perfil = @id_perfil