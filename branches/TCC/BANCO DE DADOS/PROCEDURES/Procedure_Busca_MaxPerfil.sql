USE Megatechdatabase
IF OBJECT_ID('sp_busca_maxPerfil', 'P')IS NOT NULL
	DROP PROCEDURE sp_busca_maxPerfil;
GO

create PROCEDURE [dbo].[sp_busca_maxPerfil]
AS
SELECT MAX(id_perfil) as id_perfil
FROM Perfil