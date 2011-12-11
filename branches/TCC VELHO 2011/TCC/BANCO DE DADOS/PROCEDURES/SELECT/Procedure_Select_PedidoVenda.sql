USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_pedidovenda','p') IS NOT NULL
		DROP PROCEDURE sp_select_pedidovenda;
GO

CREATE PROCEDURE sp_select_pedidovenda
@id_pedido INT
AS
SELECT id_pedido, id_venda, id_depto, dsc_venda, dat_alt, id_fam_motor, id_kit, id_tipo_prod
FROM Pedidovenda
WHERE id_pedido = @id_pedido