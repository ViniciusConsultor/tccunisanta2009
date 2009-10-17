USE Megatechdatabase 
go 
IF OBJECT_ID('sp_busca_departamento', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_busca_departamento; 
GO 

CREATE PROCEDURE sp_busca_departamento 
AS 
<<<<<<< .mine
SELECT id_depto, dsc_depto 'Departamento' FROM Departamento 
=======
SELECT id_depto, dsc_depto as 'Descrição do departamento' FROM Departamento 
>>>>>>> .r88
go