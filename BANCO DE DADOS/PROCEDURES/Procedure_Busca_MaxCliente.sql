USE Megatechdatabase
go

CREATE PROCEDURE sp_busca_maxCliente
AS
SELECT MAX(id_cli) as id_cli FROM Cliente