CREATE PROCEDURE sp_busca_submenu_default
@id_menu AS INT
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
WHERE p.id_perfil = 1
AND m.id_menu = @id_menu