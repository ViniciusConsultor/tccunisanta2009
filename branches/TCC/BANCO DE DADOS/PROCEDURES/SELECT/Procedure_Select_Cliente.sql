USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_cliente','p') IS NOT NULL
		DROP PROCEDURE sp_select_cliente;
GO

CREATE PROCEDURE sp_select_cliente
@id_cli INT
AS
SELECT id_cli, nom, tel, rua, nro_ende, compl, cep, bairr, cid, dat_atl, slg_est, mail, ddd, cpf, cnpj 
FROM Cliente
WHERE id_cli = @id_cli
AND flg_ativo = 1