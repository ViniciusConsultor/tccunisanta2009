USE Megatechdatabase
GO

IF OBJECT_ID('sp_busca_tree_familiaMotor','p') IS NOT NULL
		DROP PROCEDURE sp_busca_tree_familiaMotor;
GO

CREATE PROCEDURE sp_busca_tree_familiaMotor
@id_fam_motor INT
AS
SELECT fm.id_fam_motor, fm.id_fam_motor_real, kf.id_kit
FROM Familiamotor fm
INNER JOIN Kitfamilia kf
ON fm.id_fam_motor = kf.id_fam_motor
WHERE fm.id_fam_motor = @id_fam_motor