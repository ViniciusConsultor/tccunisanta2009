use Megatechdatabase
go

create PROCEDURE [dbo].[sp_busca_maxPerfil]
AS
SELECT MAX(id_perfil) as id_perfil
FROM Perfil