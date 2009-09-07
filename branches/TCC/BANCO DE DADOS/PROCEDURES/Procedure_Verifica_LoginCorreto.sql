CREATE PROCEDURE verifica_loginCorreto
@login VARCHAR(20),
@senha VARCHAR(15)
AS
--------------------------------------------------
--Verifica se existe aquele login com aquela senha
--------------------------------------------------
IF (EXISTS(SELECT login FROM Usuario WHERE login = @login AND senha = @senha))
PRINT 'true'
--SELECT id_tipo_usuario FROM 
ELSE
PRINT 'false'

exec verifica_loginCorreto aaa, teste


select * from usuario