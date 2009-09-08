USE Megatechdatabase
go

CREATE PROCEDURE sp_busca_departamento
AS
SELECT id_depto, dsc_depto FROM Departamento