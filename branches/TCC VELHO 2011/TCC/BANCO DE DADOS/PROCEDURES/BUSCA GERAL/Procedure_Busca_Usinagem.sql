 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_usinagem', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_usinagem;
 GO
 
 CREATE PROCEDURE sp_busca_usinagem
 AS
 SELECT u.id_usinagem, u.id_peca, p.id_peca_real as 'Código Peça', u.dta_envio as 'Data Usinagem', u.flg_status  as 'Status' FROM Usinagem u
 INNER JOIN Peca p
 ON u.id_peca = p.id_peca
 WHERE flg_ativo = 1