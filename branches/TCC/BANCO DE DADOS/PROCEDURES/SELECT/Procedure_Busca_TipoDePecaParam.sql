USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_tipodepeca_param','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_tipodepeca_param;
GO
CREATE PROCEDURE sp_busca_tipodepeca_param
@dsc_tipo_peca VARCHAR(500)
AS
<<<<<<< .mine
SELECT id_tipo_peca, dsc 'Tipo Pe�a'
=======
SELECT id_tipo_peca, dsc_tipo_peca AS 'Nome tipo da pe�a' 
>>>>>>> .r88
FROM Tipodepeca
WHERE dsc LIKE @dsc_tipo_peca  + '%'