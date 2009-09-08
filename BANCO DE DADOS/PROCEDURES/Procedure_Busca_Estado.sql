USE Megatechdatabase
go

CREATE PROCEDURE sp_busca_estado
AS
SELECT id_estado, slg_estado, nom_estado FROM Estado