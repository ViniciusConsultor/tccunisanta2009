 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_numeromotor_param', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_numeromotor_param;
 GO
 
 CREATE PROCEDURE sp_busca_numeromotor_param
@dsc_num_motor varchar(500)
 AS
 SELECT id_num_motor, id_num_motor_real, dsc_num_motor FROM Numeromotor
where dsc_num_motor like '%' + @dsc_num_motor +'%'
AND flg_ativo = 1
order by dsc_num_motor desc