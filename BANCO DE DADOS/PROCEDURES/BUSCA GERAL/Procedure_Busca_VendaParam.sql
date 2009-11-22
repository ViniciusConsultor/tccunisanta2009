 USE Megatechdatabase
 go
 IF OBJECT_ID('sp_busca_venda_param', 'P')IS NOT NULL
	 DROP PROCEDURE sp_busca_venda_param;
 GO
 
 CREATE PROCEDURE sp_busca_venda_param
 @dat_venda			DATETIME,
 @nom_cli			VARCHAR(60)
 AS
 SELECT V.id_venda 'Venda', V.dat_venda 'Data', C.nom 'Cliente' FROM Venda V
INNER JOIN Cliente C 
on V.id_cli = C.id_cli where V.dat_venda = @dat_venda and C.nom = @nom_cli
order by dat_venda desc