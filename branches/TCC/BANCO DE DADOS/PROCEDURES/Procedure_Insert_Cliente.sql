USE Megatechdatabase
go

CREATE PROCEDURE sp_insert_cliente
@id_cli			INT,
@nom_cli		VARCHAR(60),
@tel_cli		VARCHAR(20),
@nom_rua		VARCHAR(100),
@id_estado		INT,
@num_end		INT,
@compl_end		VARCHAR(20),
@cep			INT,
@bairr_end		VARCHAR(20),
@cidade			VARCHAR (50),
@id_rg			INT,
@id_cnpj		INT,
@dat_atl		DATETIME,
@flg_ativo		BIT
AS
INSERT INTO Cliente
(id_cli, nom_cli, tel_cli, nom_rua, id_estado, num_end, compl_end, cep, bairr_end, cidade, id_rg, id_cnpj, dat_atl, flg_ativo)
VALUES
(@id_cli, @nom_cli, @tel_cli, @nom_rua, @id_estado, @num_end, @compl_end, @cep, @bairr_end, @cidade, @id_rg, @id_cnpj, @dat_atl, @flg_ativo)