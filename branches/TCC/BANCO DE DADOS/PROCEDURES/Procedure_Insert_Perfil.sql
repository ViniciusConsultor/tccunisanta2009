USE Megatechdatabase
go

CREATE PROCEDURE sp_insert_perfil
@id_perfil INT,
@dsc_perfil VARCHAR(30),
@dat_atl DATETIME,
@flg_ativo BIT
AS
INSERT INTO Perfil (id_perfil, dsc_perfil, dat_atl, flg_ativo)
VALUES
(@id_perfil, @dsc_perfil, @dat_atl, @flg_ativo)