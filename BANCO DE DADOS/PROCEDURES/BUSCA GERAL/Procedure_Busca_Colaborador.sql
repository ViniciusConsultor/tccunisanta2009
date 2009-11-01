USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_colaborador','p') IS NOT NULL
		DROP PROCEDURE sp_busca_colaborador;
GO
CREATE PROCEDURE sp_busca_colaborador
AS 
SELECT id_colab, nom 'Colaborador'FROM Colaborador
WHERE flg_ativo = 1