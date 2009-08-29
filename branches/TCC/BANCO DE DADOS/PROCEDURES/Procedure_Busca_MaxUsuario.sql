CREATE PROCEDURE sp_busca_maxUsuario
AS
SELECT MAX(id_usu) as id_usu
FROM Usuario