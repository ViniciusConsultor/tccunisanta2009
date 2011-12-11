 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_peca_param', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_peca_param;
 GO
 
 CREATE PROCEDURE sp_busca_peca_param
 @nom VARCHAR(50)
 AS
 SELECT id_peca, id_peca_real, nom, 0 as 'qtd' FROM Peca
 WHERE flg_ativo = 1
 AND nom LIKE '%' + @nom + '%'