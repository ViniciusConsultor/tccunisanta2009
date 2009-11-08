 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_usuario', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_usuario;
 GO
 
 CREATE PROCEDURE sp_busca_usuario
 AS
 SELECT id_usu, log_usu 'Usuário' FROM Usuario
 WHERE flg_ativo = 1