 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_perfil_param', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_perfil_param;
 GO

 CREATE PROCEDURE sp_busca_perfil_param
 @dsc_perfil AS VARCHAR(30)
 AS
<<<<<<< .mine
 SELECT id_perfil, dsc_perfil as 'Perfil'
=======
 SELECT id_perfil, dsc_perfil AS 'Descrição perfil' 
>>>>>>> .r88
 FROM Perfil
 WHERE dsc_perfil LIKE @dsc_perfil + '%'
go