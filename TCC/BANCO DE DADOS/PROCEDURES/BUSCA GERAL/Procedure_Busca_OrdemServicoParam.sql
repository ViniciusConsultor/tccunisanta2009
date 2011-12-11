 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_ordemservico_param', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_ordemservico_param;
 GO
 
 CREATE PROCEDURE sp_busca_ordemservico_param
 @id_ordem_serv			INT
 AS
 SELECT id_ordem_serv FROM ordemservico
 where id_ordem_serv = @id_ordem_serv
order by id_ordem_serv