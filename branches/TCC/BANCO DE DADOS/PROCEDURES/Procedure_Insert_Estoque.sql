USE Megatechdatabase

GO

CREATE PROCEDURE sp_insere_estoque
@id_estoque INT,
@nom_estoque VARCHAR,
@dat_alt DATETIME,
@flg_ativo BIT,
@id_depto INT

AS 
INSERT INTO ESTOQUE
( id_estoque, nom_estoque, dat_alt, flg_ativo, id_depto)

VALUES 
(@id_estoque, @nom_estoque, @dat_alt, @flg_ativo, @id_depto)