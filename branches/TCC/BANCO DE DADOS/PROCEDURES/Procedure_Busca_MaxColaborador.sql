use Megatechdatabase
go

create PROCEDURE [dbo].[sp_busca_maxColaborador]
AS
SELECT MAX(id_colab) as id_colab
FROM Colaborador