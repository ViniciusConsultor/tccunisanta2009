USE Megatechdatabase
go

CREATE PROCEDURE sp_insert_tipoUsuario
@id_tipo_usuario INT,
@dsc_tipo_usuario VARCHAR(500)
AS
INSERT INTO 
Tipousuario (id_tipo_usuario, dsc_tipo_usuario)
VALUES
(@id_tipo_usuario, @dsc_tipo_usuario)