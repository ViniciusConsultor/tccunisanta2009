USE Megatechdatabase
go

CREATE PROCEDURE sp_busca_perfil
AS
SELECT id_perfil, dsc_perfil FROM Perfil