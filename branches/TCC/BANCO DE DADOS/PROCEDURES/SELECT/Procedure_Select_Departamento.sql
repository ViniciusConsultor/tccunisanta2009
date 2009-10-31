USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_departamento','p') IS NOT NULL
		DROP PROCEDURE sp_select_departamento;
GO

CREATE PROCEDURE sp_select_departamento
@id_depto INT
AS
SELECT id_depto, dsc_depto, dat_atl
FROM Departamento
WHERE id_depto = @id_depto
AND flg_ativo = 1