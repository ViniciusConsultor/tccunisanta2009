USE Megatechdatabase
go
IF OBJECT_ID('sp_busca_estado', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_busca_estado; 
GO 

CREATE PROCEDURE sp_busca_estado 
 AS 
 SELECT slg_est, nom_est 'Estado' FROM Estado 
go