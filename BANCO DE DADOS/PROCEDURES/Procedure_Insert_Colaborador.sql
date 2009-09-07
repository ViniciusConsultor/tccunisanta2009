USE Megatechdatabase
go

CREATE PROCEDURE sp_insert_colaborador
@id_colab INT,
@nom_colab VARCHAR(40),
@dat_nasc DATETIME,
@nom_rua VARCHAR(50),
@nro_end INT,
@compl_end VARCHAR(20),
@cep VARCHAR(10),
@bairr_end VARCHAR(30),
@cidade VARCHAR(40),
@rg VARCHAR(15),
@cpf VARCHAR(15),
@sexo CHAR(1),
@dat_atl DATETIME,
@flg_ativo BIT,
@id_usu INT,
@id_depto INT,
@id_estado INT
AS
INSERT INTO 
Colaborador(id_colab, nom_colab, dat_nasc, nom_rua, nro_end, compl_end, cep, bairr_end, cidade, rg, cpf, sexo, dat_atl, flg_ativo, id_usu, id_depto, id_estado)
VALUES
(@id_colab, @nom_colab, @dat_nasc, @nom_rua, @nro_end, @compl_end, @cep, @bairr_end, @cidade, @rg, @cpf, @sexo, @dat_atl, @flg_ativo, @id_usu, @id_depto, @id_estado)