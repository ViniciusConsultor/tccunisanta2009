USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_kitgrupopeca_codigo', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_kitgrupopeca_codigo; 
GO 

CREATE PROCEDURE sp_existe_kitgrupopeca_codigo
@id_kit_real VARCHAR(25)
AS

SELECT COUNT(id_kit_real) as flg_existe
FROM kitgrupopeca
WHERE id_kit_real LIKE @id_kit_real
AND flg_ativo = 1