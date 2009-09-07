USE Megatechdatabase
go

CREATE PROCEDURE sp_busca_perfil_param
@dsc_perfil AS VARCHAR(30)
AS
SELECT id_perfil, dsc_perfil 
FROM Perfil
WHERE dsc_perfil LIKE @dsc_perfil + '%'