 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_usuario', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_usuario;
 GO
 
 CREATE PROCEDURE sp_busca_usuario
 AS
<<<<<<< .mine
 SELECT id_usu, log_usu 'Usu�rio' FROM Usuario
=======
 SELECT id_usu, login AS 'Login usuario' FROM Usuario
>>>>>>> .r88
go