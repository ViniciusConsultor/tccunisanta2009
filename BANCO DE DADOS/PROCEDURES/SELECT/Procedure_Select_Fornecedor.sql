USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_fornecedor','p') IS NOT NULL
		DROP PROCEDURE sp_select_fornecedor;
GO

CREATE PROCEDURE sp_select_fornecedor
@id_forn INT
AS
SELECT id_forn, nom, rua, nro_ende, compl, cep, ddd, bairr, tel, cid, mail, cnpj, dat_alt, slg_est
FROM Fornecedor
WHERE id_forn = @id_forn
AND flg_ativo = 1