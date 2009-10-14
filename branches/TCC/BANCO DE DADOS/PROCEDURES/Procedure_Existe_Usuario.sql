USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_usuario', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_usuario; 
GO 

CREATE PROCEDURE sp_existe_usuario
@usuario VARCHAR(20)
AS

SELECT COUNT(login) as flg_existe
FROM Usuario
WHERE login LIKE @usuario