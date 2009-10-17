 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_perfil', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_perfil;
 GO
 
 CREATE PROCEDURE sp_busca_perfil
 AS
<<<<<<< .mine
 SELECT id_perfil, dsc_perfil as 'Perfil' FROM Perfil
=======
 SELECT id_perfil, dsc_perfil as 'Descrição do perfil' FROM Perfil
>>>>>>> .r88
go