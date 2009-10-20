USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_ordemProducao','p') IS NOT NULL
		DROP PROCEDURE sp_busca_ordemProducao;
GO

CREATE PROCEDURE sp_busca_ordemProducao
AS
SELECT id_ordem, dsc_ordem as 'Ordem' FROM Ordemproducao