USE Megatechdatabase
IF OBJECT_ID('sp_busca_maxCliente', 'P')IS NOT NULL
	DROP PROCEDURE sp_busca_maxCliente;
GO

CREATE PROCEDURE sp_busca_maxCliente
AS
SELECT MAX(id_cli) as id_cli FROM Cliente