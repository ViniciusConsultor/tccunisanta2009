USE Megatechdatabase
go

CREATE PROCEDURE [dbo].[sp_busca_tipoUsuario]
AS
SELECT id_tipo_usuario, dsc_tipo_usuario
FROM Tipo_de_Usuário