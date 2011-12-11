 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_peca_param_codigo', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_peca_param_codigo;
 GO
 
 CREATE PROCEDURE sp_busca_peca_param_codigo
@id_peca_real VARCHAR(25)
 AS
 SELECT id_peca, id_peca_real, nom, 0 as 'qtd' FROM Peca
 WHERE id_peca_real LIKE '%' + @id_peca_real + '%'
 AND flg_ativo = 1