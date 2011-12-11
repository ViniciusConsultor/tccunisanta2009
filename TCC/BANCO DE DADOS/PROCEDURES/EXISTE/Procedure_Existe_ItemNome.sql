USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_itemNome', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_itemNome; 
GO 

CREATE PROCEDURE sp_existe_itemNome
@nom VARCHAR(25)
AS

SELECT COUNT(nom) as flg_existe
FROM Item
WHERE nom LIKE @nom
AND flg_ativo = 1