USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_perfil','p') IS NOT NULL
		DROP PROCEDURE sp_select_perfil;
GO

CREATE PROCEDURE sp_select_perfil
@id_perfil INT
AS
SELECT id_perfil, dsc_perfil, dat_atl, flg_ativo
FROM Perfil
WHERE id_perfil = @id_perfil