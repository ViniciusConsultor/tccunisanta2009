USE Megatechdatabase
go

IF OBJECT_ID('sp_existe_peca', 'P')IS NOT NULL 
	 DROP PROCEDURE sp_existe_peca; 
GO 

CREATE PROCEDURE sp_existe_peca
@id_peca_real VARCHAR(50)
AS

SELECT COUNT(id_peca_real) as flg_existe
FROM Peca
WHERE id_peca_real LIKE @id_peca_real
AND flg_ativo = 1