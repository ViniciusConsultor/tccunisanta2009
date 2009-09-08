CREATE PROCEDURE sp_insert_perfilMenu
@id_perfil INT,
@id_menu INT,
@dat_trans DATETIME,
@flg_ativo BIT
AS
INSERT INTO Perfilmenu 
(id_perfil, id_menu, dat_trans, flg_ativo)
VALUES
(@id_perfil, @id_menu, @dat_trans, @flg_ativo)