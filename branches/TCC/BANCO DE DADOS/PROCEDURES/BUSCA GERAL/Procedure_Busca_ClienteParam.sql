USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_cliente_param','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_cliente_param;
GO
CREATE PROCEDURE sp_busca_cliente_param
@nom_cli AS VARCHAR(60)
AS 
SELECT id_cli, nom 'Cliente', mail
FROM cliente 
WHERE  nom like '%' + @nom_cli + '%'
AND flg_ativo = 1
