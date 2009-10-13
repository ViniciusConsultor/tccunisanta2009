USE Megatechdatabase
IF OBJECT_ID('sp_insert_usuarioPerfil', 'P')IS NOT NULL
	DROP PROCEDURE sp_insert_usuarioPerfil;
GO

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