USE Megatechdatabase
go

CREATE PROCEDURE sp_busca_usuario
AS
SELECT id_usu, login, senha, obs_usu, flg_ativo FROM Usuario