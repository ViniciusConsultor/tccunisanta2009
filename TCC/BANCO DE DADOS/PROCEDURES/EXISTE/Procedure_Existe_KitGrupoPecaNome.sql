USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_kitgrupopeca_nome', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_kitgrupopeca_nome; 
GO 

CREATE PROCEDURE sp_existe_kitgrupopeca_nome
@nom VARCHAR(50)
AS

SELECT COUNT(id_kit_real) as flg_existe
FROM kitgrupopeca
WHERE nom LIKE @nom
AND flg_ativo = 1