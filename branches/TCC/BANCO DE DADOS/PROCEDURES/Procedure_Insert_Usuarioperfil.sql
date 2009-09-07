USE Megatechdatabase
go

CREATE PROCEDURE sp_insert_usuarioPerfil
@id_usu INT,
@id_perfil INT,
@dat_trans DATETIME,
@flg_ativo BIT
AS
INSERT INTO Usuarioperfil 
(id_usu, id_perfil, dat_trans, flg_ativo)
VALUES
(@id_usu, @id_perfil, @dat_trans, @flg_ativo)