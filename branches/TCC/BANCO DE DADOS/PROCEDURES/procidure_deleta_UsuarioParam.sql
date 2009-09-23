USE Megatechdatabase
go

CREATE PROCEDURE sp_deleta_usuario
@id_usu INT
AS
DELETE Usuario
WHERE id_usu = @id_usu