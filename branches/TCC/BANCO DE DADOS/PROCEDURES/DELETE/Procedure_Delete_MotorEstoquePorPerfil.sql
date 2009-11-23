USE Megatechdatabase
GO
IF OBJECT_ID('sp_delete_motorestoqueporperfil', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_motorestoqueporperfil;
GO

CREATE PROCEDURE sp_delete_motorestoqueporperfil
@id_motor    	INT
AS
DELETE motorestoque
WHERE id_motor = @id_motor
