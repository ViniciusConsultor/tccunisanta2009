use Megatechdatabase
go

create PROCEDURE [dbo].[sp_busca_maxDepto]
AS
SELECT MAX(id_depto) as id_depto
FROM Departamento