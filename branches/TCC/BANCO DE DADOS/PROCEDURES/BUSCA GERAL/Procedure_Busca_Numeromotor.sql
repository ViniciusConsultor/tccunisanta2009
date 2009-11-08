 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_numeromotor', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_numeromotor;
 GO
 
 CREATE PROCEDURE sp_busca_numeromotor
 AS
 SELECT id_num_motor, dsc_num_motor 'Numero do motor' FROM Numeromotor
 WHERE flg_ativo = 1
order by dsc_num_motor desc