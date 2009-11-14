USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_usuario', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_usuario; 
GO 

CREATE PROCEDURE sp_existe_usuario
@usuario VARCHAR(20)
AS

SELECT COUNT(log_usu) as flg_existe
FROM Usuario
WHERE log_usu LIKE @usuario
AND flg_ativo = 1