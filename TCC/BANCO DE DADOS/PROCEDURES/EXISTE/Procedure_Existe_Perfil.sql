USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_perfil', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_perfil; 
GO 

CREATE PROCEDURE sp_existe_perfil
@dsc_perfil VARCHAR(50)
AS

SELECT COUNT(dsc_perfil) as flg_existe
FROM Perfil
WHERE dsc_perfil LIKE @dsc_perfil
AND flg_ativo = 1