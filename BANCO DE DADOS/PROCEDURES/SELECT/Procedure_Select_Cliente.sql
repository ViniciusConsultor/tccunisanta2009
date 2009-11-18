USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_cliente','p') IS NOT NULL
		DROP PROCEDURE sp_select_cliente;
GO

CREATE PROCEDURE sp_select_cliente
@id_cli INT
AS
SELECT id_cli, nom, tel, rua, nro_ende, compl, cod_post, bairr, cid, cpf, dat_atl, flg_ativo, mail, ddd, cnpj, nom_est_inter, nom_pais, slg_est, ident_inter, ddi
FROM Cliente
WHERE id_cli = @id_cli
AND flg_ativo = 1