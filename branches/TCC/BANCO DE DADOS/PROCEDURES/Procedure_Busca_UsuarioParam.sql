USE Megatechdatabase
go

CREATE PROCEDURE sp_busca_usuario_param
@login VARCHAR(20)
AS
SELECT id_usu, login, senha, obs_usu, flg_ativo FROM Usuario
WHERE login = @login + '%'
