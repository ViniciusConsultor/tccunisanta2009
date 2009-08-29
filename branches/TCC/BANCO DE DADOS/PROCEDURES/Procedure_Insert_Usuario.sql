CREATE PROCEDURE sp_insert_usuario
@id_usu INT,
@login VARCHAR(20),
@senha VARCHAR(15),
@id_tipo_usuario INT,
@obs_usu VARCHAR(100),
@flg_ativo BIT
AS
INSERT INTO 
Usuario (id_usu, login, senha, id_tipo_usuario, obs_usu, flg_ativo)
VALUES
(@id_usu, @login, @senha, @id_tipo_usuario, @obs_usu, @flg_ativo)