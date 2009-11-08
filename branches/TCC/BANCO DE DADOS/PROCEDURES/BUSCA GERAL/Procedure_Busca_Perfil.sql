 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_perfil', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_perfil;
 GO
 
 CREATE PROCEDURE sp_busca_perfil
 AS
 SELECT id_perfil, dsc_perfil as 'Perfil' FROM Perfil
 WHERE flg_ativo = 1