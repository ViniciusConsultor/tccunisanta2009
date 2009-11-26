 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_ordemservico_paramvenda', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_ordemservico_paramvenda;
 GO
 
 CREATE PROCEDURE sp_busca_ordemservico_paramvenda
 @id_venda			INT
 AS
 SELECT id_ordem_serv FROM ordemservico
 where id_venda = @id_venda
order by id_ordem_serv