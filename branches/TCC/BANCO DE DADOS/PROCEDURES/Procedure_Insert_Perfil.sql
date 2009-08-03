create procedure sp_insert_perfil
@id_perfil int,
@dsc_perfil varchar(30),
@dat_atl datetime,
@flg_ativo bit
as
insert into Perfil (id_perfil, dsc_perfil, dat_atl, flg_ativo)
values
(@id_perfil, @dsc_perfil, @dat_atl, @flg_ativo)