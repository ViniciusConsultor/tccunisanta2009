 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_usuario_param', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_usuario_param;
 GO
 
 CREATE PROCEDURE sp_busca_usuario_param
 @login VARCHAR(20)
 AS
 SELECT id_usu, login FROM Usuario
 WHERE login LIKE @login + '%'
go