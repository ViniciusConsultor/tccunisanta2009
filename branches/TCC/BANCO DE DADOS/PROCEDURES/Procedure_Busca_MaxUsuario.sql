USE Megatechdatabase
IF OBJECT_ID('sp_busca_maxUsuario', 'P')IS NOT NULL
	DROP PROCEDURE sp_busca_maxUsuario;
GO

CREATE PROCEDURE sp_busca_maxUsuario
AS
SELECT MAX(id_usu) as id_usu
FROM Usuario