USE Megatechdatabase
IF OBJECT_ID('verifica_loginCorreto', 'P')IS NOT NULL
	DROP PROCEDURE verifica_loginCorreto;
GO

CREATE PROCEDURE verifica_loginCorreto
@login VARCHAR(20),
@senha VARCHAR(15)
AS
--------------------------------------------------
--Verifica se existe aquele login com aquela senha
--------------------------------------------------
IF (EXISTS(SELECT log_usu FROM Usuario WHERE log_usu = @login AND senha = @senha))
	SELECT p.id_perfil FROM Perfil p 
	INNER JOIN Usuarioperfil up
	ON p.id_perfil = up.id_perfil
	INNER JOIN Usuario us
	ON up.id_usu = us.id_usu
	WHERE us.log_usu = @login AND us.senha = @senha
ELSE
	SELECT 0 AS id_perfil