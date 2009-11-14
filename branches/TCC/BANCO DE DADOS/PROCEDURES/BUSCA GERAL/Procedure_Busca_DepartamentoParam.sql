USE Megatechdatabase
go

IF OBJECT_ID ('sp_busca_departamento_param', 'P') IS NOT NULL
		DROP PROCEDURE sp_busca_departamento_param;
GO

CREATE PROCEDURE sp_busca_departamento_param
@nom VARCHAR(25)
AS
SELECT id_depto, nom, dsc_depto
FROM Departamento
WHERE nom LIKE '%' + @nom + '%'
AND flg_ativo = 1
