USE Megatechdatabase
IF OBJECT_ID('sp_busca_maxDepto', 'P')IS NOT NULL
	DROP PROCEDURE sp_busca_maxDepto;
GO

create PROCEDURE [dbo].[sp_busca_maxDepto]
AS
SELECT MAX(id_depto) as id_depto
FROM Departamento