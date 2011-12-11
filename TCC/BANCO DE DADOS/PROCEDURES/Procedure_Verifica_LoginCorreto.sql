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
	SELECT us.id_usu FROM Usuario us
	WHERE us.log_usu = @login AND us.senha = @senha
ELSE
	SELECT 0 AS id_usu

