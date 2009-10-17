USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_cliente_param','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_cliente_param;
GO
CREATE PROCEDURE sp_busca_cliente_param
@nom_cli AS VARCHAR(60)
AS 
<<<<<<< .mine
SELECT id_cli, nom 'Cliente', mail
=======
SELECT id_cli , nom_cli as 'Nome do cliente', email_cliente as 'E-mail'
>>>>>>> .r88
FROM cliente 
WHERE  nom like @nom_cli + '%'