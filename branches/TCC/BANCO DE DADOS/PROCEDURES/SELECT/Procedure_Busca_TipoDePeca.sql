USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_tipodepeca','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_tipodepeca;
GO
CREATE PROCEDURE sp_busca_tipodepeca
AS
<<<<<<< .mine
SELECT id_tipo_peca, dsc 'Tipo Pe�a' FROM Tipodepeca=======
SELECT id_tipo_peca, dsc_tipo_peca AS 'Nome tipo da pe�a'
FROM Tipodepeca>>>>>>> .r88
