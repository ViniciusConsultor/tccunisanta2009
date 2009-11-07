 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_peca_param_nome', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_peca_param_nome;
 GO
 
 CREATE PROCEDURE sp_busca_peca_param_nome
@nom VARCHAR(50)
 AS
 SELECT id_peca, id_peca_real as 'Codigo', nom as 'Peça', 0 as 'qtd' FROM Peca
WHERE nom LIKE '%' + @nom + '%'
AND flg_ativo = 1