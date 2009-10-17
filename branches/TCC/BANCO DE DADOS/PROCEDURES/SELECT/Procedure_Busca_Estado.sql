USE Megatechdatabase
go
IF OBJECT_ID('sp_busca_estado', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_busca_estado; 
GO 

CREATE PROCEDURE sp_busca_estado 
 AS 
<<<<<<< .mine
 SELECT slg_estado, nom_estado 'Estado' FROM Estado 
=======
 SELECT slg_estado as 'Sigla do estado', nom_estado as 'Nome do estado' FROM Estado 
>>>>>>> .r88
go