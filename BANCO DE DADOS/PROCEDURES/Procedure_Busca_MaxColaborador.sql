USE Megatechdatabase
IF OBJECT_ID('sp_busca_maxColaborador', 'P')IS NOT NULL
	DROP PROCEDURE sp_busca_maxColaborador;
GO

create PROCEDURE [dbo].[sp_busca_maxColaborador]
AS
SELECT MAX(id_colab) as id_colab
FROM Colaborador