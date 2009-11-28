USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_produto','p') IS NOT NULL
		DROP PROCEDURE sp_select_produto;
GO

CREATE PROCEDURE sp_select_produto
@id_prdto INT
AS
SELECT id_prdto, dsc_prdto, id_fam_motor, id_kit, id_tipo_produto, flg_ativo, dat_alt
FROM Produto
WHERE id_prdto = @id_prdto
AND flg_ativo = 1