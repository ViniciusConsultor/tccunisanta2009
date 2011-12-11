USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_ordemProducao_param','p') IS NOT NULL
		DROP PROCEDURE sp_busca_ordemProducao_param;
GO

CREATE PROCEDURE sp_busca_ordemProducao_param
@dsc_ordem VARCHAR(500)
AS
SELECT id_ordem, dsc_ordem as 'Ordem' FROM Ordemproducao
WHERE dsc_ordem LIKE '%' + @dsc_ordem + '%'