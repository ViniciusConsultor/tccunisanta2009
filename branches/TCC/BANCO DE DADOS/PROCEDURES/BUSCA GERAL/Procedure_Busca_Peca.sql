 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_peca', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_peca;
 GO
 
 CREATE PROCEDURE sp_busca_peca
 AS
 SELECT id_peca, nom as 'Pe�a' FROM Peca
 WHERE flg_ativo = 1