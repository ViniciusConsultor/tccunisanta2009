USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_cliente','p') IS NOT NULL
		DROP PROCEDURE sp_select_cliente;
GO

CREATE PROCEDURE sp_select_cliente
@id_cli INT
AS
SELECT id_cli, nom, tel, rua, nro_ende, compl, cep, bairr, cid, rg, cnpj, dat_atl, flg_ativo, slg_est, mail, ddd
FROM Cliente
WHERE id_cli = @id_cli