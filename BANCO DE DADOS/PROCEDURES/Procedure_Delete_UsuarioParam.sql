USE Megatechdatabase
go

CREATE PROCEDURE sp_delete_usuario
@id_usu INT
AS
DELETE Usuario
WHERE id_usu = @id_usu