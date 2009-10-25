USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_cliente','p') IS NOT NULL
		DROP PROCEDURE sp_busca_cliente;
GO
CREATE PROCEDURE sp_busca_cliente
AS 
SELECT id_cli, nom 'Cliente', mail FROM Cliente
WHERE flg_ativo = 1