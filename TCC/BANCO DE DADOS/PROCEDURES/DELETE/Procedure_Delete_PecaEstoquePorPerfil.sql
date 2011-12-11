USE Megatechdatabase
GO
IF OBJECT_ID('sp_delete_pecaestoqueporperfil', 'P')IS NOT NULL
	DROP PROCEDURE sp_delete_pecaestoqueporperfil;
GO

CREATE PROCEDURE sp_delete_pecaestoqueporperfil
@id_peca    	INT
AS
DELETE pecaestoque
WHERE id_peca = @id_peca
