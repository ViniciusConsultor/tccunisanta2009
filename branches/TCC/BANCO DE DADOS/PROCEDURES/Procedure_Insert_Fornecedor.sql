USE Megatechdatabase
go

CREATE PROCEDURE sp_insert_fornecedor
@id_fornecedor			INT,
@nom_fornecedor			VARCHAR(100),
@nom_rua_fornecedor		VARCHAR(50),
@nro_end_fornecedor		INT,
@compl_end_fornecedor	VARCHAR(20),
@cep_fornecedor			INT,
@bairr_end_fornecedor	VARCHAR(50),
@cidade_fornecedor		VARCHAR(50),
@id_cnpj_fornecedor		INT,
@dat_alt				DATETIME,
@flg_ativo				BIT,
@id_estado				INT
AS
INSERT INTO Fornecedor 
(id_fornecedor, nom_fornecedor, nom_rua_fornecedor, nro_end_fornecedor, compl_end_fornecedor, cep_fornecedor, bairr_end_fornecedor, cidade_fornecedor, id_cnpj_fornecedor, dat_alt, flg_ativo, id_estado)
VALUES 
(@id_fornecedor, @nom_fornecedor, @nom_rua_fornecedor, @nro_end_fornecedor, @compl_end_fornecedor, @cep_fornecedor, @bairr_end_fornecedor, @cidade_fornecedor, @id_cnpj_fornecedor, @dat_alt, @flg_ativo, @id_estado)