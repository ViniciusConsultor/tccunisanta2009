 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_kitGrupoPeca', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_kitGrupoPeca;
 GO

 CREATE PROCEDURE sp_busca_kitGrupoPeca
 AS
 SELECT id_kit as 'Id', id_kit_real as 'Codigo', nom as 'Nome', 0 as 'Qtd' FROM Kitgrupopeca
WHERE flg_ativo = 1