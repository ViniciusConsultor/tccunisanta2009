USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_colaborador','p') IS NOT NULL
		DROP PROCEDURE sp_select_colaborador;
GO

CREATE PROCEDURE sp_select_colaborador
@id_colab INT
AS
SELECT id_colab, nom, dat_nasc, rua, nro_ende, compl, cep, bairr, ddd, cid, tel, rg, cpf, sex, mail, dat_atl, id_usu, id_depto, slg_est, flg_ativo
FROM Colaborador
WHERE id_colab = @id_colab
AND flg_ativo = 1