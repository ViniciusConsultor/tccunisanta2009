 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_peca_param', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_peca_param;
 GO
 
 CREATE PROCEDURE sp_busca_peca_param
@nom VARCHAR(50)
 AS
 SELECT id_peca, nom as 'Peça' FROM Peca
WHERE nom LIKE @nom + '%'
AND flg_ativo = 1