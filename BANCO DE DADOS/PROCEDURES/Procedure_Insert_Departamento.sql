CREATE PROCEDURE sp_insert_departamento
@id_depto INT,
@dsc_depto VARCHAR(30),
@dat_atl DATETIME,
@flg_ativo BIT
AS

INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, flg_ativo)
VALUES (@id_depto, @dsc_depto, @dat_atl, @flg_ativo)