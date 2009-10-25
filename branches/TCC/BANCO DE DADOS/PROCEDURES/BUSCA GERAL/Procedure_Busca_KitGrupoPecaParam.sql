 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_kitGrupoPeca_param', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_kitGrupoPeca_param;
 GO

 CREATE PROCEDURE sp_busca_kitGrupoPeca_param
 @nom AS VARCHAR(50)
 AS
 SELECT id_grupo, nom as 'Kit Grupo Peça'
 FROM Kitgrupopeca
 WHERE nom LIKE @nom + '%'
 AND flg_ativo = 1
go