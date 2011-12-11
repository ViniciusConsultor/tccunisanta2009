 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_ordemservico', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_ordemservico;
 GO
 
 CREATE PROCEDURE sp_busca_ordemservico
 AS
 SELECT id_ordem_serv FROM ordemservico
order by id_ordem_serv