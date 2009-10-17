USE Megatechdatabase
go

IF OBJECT_ID ('sp_busca_departamento_param', 'P') IS NOT NULL
		DROP PROCEDURE sp_busca_departamento_param;
GO

CREATE PROCEDURE sp_busca_departamento_param
@dsc_departamento VARCHAR(30)
AS
<<<<<<< .mine
SELECT id_depto, dsc_depto 'Departamento'
=======
SELECT id_depto, dsc_depto as 'Descrição do departamento '
>>>>>>> .r88
FROM Departamento
WHERE dsc_depto LIKE @dsc_departamento + '%'