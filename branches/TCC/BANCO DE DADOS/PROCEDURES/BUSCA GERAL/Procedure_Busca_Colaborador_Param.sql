USE Megatechdatabase
GO
IF OBJECT_ID('sp_busca_colaborador_param','P')IS NOT NULL	
		DROP PROCEDURE sp_busca_colaborador_param;
GO
CREATE PROCEDURE sp_busca_colaborador_param
@nom_colab AS VARCHAR(60)
AS 
SELECT id_colab, nom 'Colaborador'
FROM colaborador
WHERE  nom like '%' + @nom_colab + '%'
AND flg_ativo = 1
