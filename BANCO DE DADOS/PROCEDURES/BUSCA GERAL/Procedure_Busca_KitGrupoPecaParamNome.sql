 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_kitGrupoPeca_param_nome', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_kitGrupoPeca_param_nome;
 GO

 CREATE PROCEDURE sp_busca_kitGrupoPeca_param_nome
 @nom AS VARCHAR(50)
 AS
 SELECT id_kit, id_kit_real, nom, 0 as 'Qtd' 
 FROM Kitgrupopeca
 WHERE nom LIKE '%' + @nom + '%'
 AND flg_ativo = 1