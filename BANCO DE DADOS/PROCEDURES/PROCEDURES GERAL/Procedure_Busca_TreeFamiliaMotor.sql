USE Megatechdatabase
GO

IF OBJECT_ID('sp_busca_tree_familiamotor','p') IS NOT NULL
		DROP PROCEDURE sp_busca_tree_familiamotor;
GO

CREATE PROCEDURE sp_busca_tree_familiamotor
@id_fam_motor INT
AS
SELECT kf.id_kit, kf.qtd_kit, fm.id_fam_motor, fm.id_num_motor, fm.dsc_fam_motor, fm.flg_ativo, fm.id_motor, fm.id_estoque, fm.id_fam_motor_real, fm.id_tipo_motor
FROM Familiamotor fm
INNER JOIN Kitfamilia kf
ON fm.id_fam_motor = kf.id_fam_motor
WHERE fm.id_fam_motor = @id_fam_motor
AND fm.flg_ativo = 1

-- exec sp_busca_tree_familiamotor 1


SELECT * FROM Kitfamilia