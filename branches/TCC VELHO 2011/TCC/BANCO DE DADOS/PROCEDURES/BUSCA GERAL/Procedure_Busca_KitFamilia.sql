 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_kitFamilia', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_kitFamilia;
 GO

 CREATE PROCEDURE sp_busca_kitFamilia
 AS
 SELECT id_kit, id_fam_motor FROM kitfamilia
WHERE flg_ativo = 1