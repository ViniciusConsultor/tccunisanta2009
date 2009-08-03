
create procedure sp_insert_colaborador
@id_colab int,
@id_usu int,
@id_depto int,
@nom_colab varchar(40),
@dat_nasc datetime,
@nom_rua varchar,
@nro_end int,
@compl_end varchar,
@cep varchar,
@bairr_end varchar(30),
@cidade varchar(40),
@estado char(2),
@rg varchar(15),
@cpf varchar(15),
@sexo char(1),
@dat_atl datetime,
@flg_ativo bit
as
insert into Colaborador(id_colab, id_usu, id_depto, nom_colab, dat_nasc, nom_rua, nro_end, compl_end, cep, bairr_end, cidade, estado, rg, cpf, sexo, dat_atl, flg_ativo)
values
(@id_colab, @id_usu, @id_depto, @nom_colab, @dat_nasc, @nom_rua, @nro_end, @compl_end, @cep, @bairr_end, @cidade, @estado, @rg, @cpf, @sexo, @dat_atl, @flg_ativo)