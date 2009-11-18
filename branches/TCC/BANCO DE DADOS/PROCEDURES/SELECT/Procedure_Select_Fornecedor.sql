USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_fornecedor','p') IS NOT NULL
		DROP PROCEDURE sp_select_fornecedor;
GO

CREATE PROCEDURE sp_select_fornecedor
@id_forn INT
AS
SELECT id_forn, nom, rua, nro_ende, compl, cod_post, ddd, bairr, tel, cid, mail, cnpj, dat_alt, flg_ativo, slg_est, nom_pais, nom_est_inter, ddi,ident_inter
FROM Fornecedor
WHERE id_forn = @id_forn
AND flg_ativo = 1