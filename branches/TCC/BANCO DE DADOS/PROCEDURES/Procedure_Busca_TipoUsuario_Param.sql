CREATE PROCEDURE [dbo].[sp_busca_tipoUsuario_param]
@dsc_tipo_usuario VARCHAR(500)
AS
SELECT id_tipo_usuario, dsc_tipo_usuario
FROM Tipo_de_Usuário
WHERE dsc_tipo_usuario LIKE @dsc_tipo_usuario + '%'