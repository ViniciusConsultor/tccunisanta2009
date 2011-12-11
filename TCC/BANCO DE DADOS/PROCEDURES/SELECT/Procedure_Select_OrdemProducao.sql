USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_ordemproducao','p') IS NOT NULL
		DROP PROCEDURE sp_select_ordemproducao;
GO

CREATE PROCEDURE sp_select_ordemproducao
@id_ordem INT
AS
SELECT id_ordem, dsc_ordem, id_fam_motor, id_kit, id_tipo_produto
FROM Ordemproducao
WHERE id_ordem = @id_ordem