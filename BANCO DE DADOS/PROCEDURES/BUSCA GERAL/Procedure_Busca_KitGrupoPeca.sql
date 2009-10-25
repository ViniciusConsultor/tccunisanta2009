 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_kitGrupoPeca', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_kitGrupoPeca;
 GO

 CREATE PROCEDURE sp_busca_kitGrupoPeca
 AS
 SELECT id_grupo, nom as 'Kit Grupo Peça'
 FROM Kitgrupopeca
WHERE flg_ativo = 1