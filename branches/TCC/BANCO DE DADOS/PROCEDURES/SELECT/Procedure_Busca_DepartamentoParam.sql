USE Megatechdatabase
go

IF OBJECT_ID ('sp_busca_departamento_param', 'P') IS NOT NULL
		DROP PROCEDURE sp_busca_departamento_param;
GO

CREATE PROCEDURE sp_busca_departamento_param
@dsc_departamento VARCHAR(30)
AS
SELECT id_depto, dsc_depto as 'Descrição do departamento '
FROM Departamento
WHERE dsc_depto LIKE @dsc_departamento + '%'