USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_cliente_param','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_cliente_param;
GO
CREATE PROCEDURE sp_busca_cliente_param
@nom_cli AS VARCHAR(60)
AS 
SELECT id_cli , nom_cli, email_cliente
FROM cliente 
WHERE  nom_cli like @nom_cli + '%'