 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_venda', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_venda;
 GO
 
 CREATE PROCEDURE sp_busca_venda
 AS
 SELECT id_venda 'Venda', dat_venda 'Data' FROM Venda
order by dat_venda desc
go