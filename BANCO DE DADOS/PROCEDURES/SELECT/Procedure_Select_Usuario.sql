USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_usuario','p') IS NOT NULL
		DROP PROCEDURE sp_select_usuario;
GO

CREATE PROCEDURE sp_select_usuario
@id_usu INT
AS
SELECT id_usu, log_usu, senha, obs_usu, flg_ativo
FROM Usuario
WHERE id_usu = @id_usu