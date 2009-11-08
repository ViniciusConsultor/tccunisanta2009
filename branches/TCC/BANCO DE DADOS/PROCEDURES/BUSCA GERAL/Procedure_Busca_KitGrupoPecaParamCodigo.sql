 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_kitGrupoPeca_param_codigo', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_kitGrupoPeca_param_codigo;
 GO

 CREATE PROCEDURE sp_busca_kitGrupoPeca_param_codigo
 @id_kit_real AS VARCHAR(25)
 AS
 SELECT id_kit as 'Id', id_kit_real as 'Codigo', nom as 'Nome', 0 as 'Qtd' 
 FROM Kitgrupopeca
 WHERE id_kit_real LIKE '%' + @id_kit_real + '%'
 AND flg_ativo = 1