USE Megatechdatabase
GO

IF OBJECT_ID('sp_select_usinagem','p') IS NOT NULL
		DROP PROCEDURE sp_select_usinagem;
GO

CREATE PROCEDURE sp_select_usinagem
@id_usinagem INT
AS
SELECT id_usinagem, flg_status,id_peca, dta_envio
FROM Usinagem
WHERE id_usinagem = @id_usinagem