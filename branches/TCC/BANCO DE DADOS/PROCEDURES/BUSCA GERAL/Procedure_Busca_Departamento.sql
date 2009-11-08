USE Megatechdatabase 
go 

IF OBJECT_ID('sp_busca_departamento', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_busca_departamento; 
GO 

CREATE PROCEDURE sp_busca_departamento 
AS 
SELECT id_depto, dsc_depto AS 'Departamento' FROM Departamento 
WHERE flg_ativo = 1