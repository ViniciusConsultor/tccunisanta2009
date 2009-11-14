USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_departamento', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_departamento; 
GO 

CREATE PROCEDURE sp_existe_departamento
@nom VARCHAR(25)
AS

SELECT COUNT(nom) as flg_existe
FROM Departamento
WHERE nom LIKE @nom
AND flg_ativo = 1