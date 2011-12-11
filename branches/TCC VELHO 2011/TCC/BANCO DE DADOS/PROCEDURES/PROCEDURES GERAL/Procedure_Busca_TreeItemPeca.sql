USE Megatechdatabase
GO

IF OBJECT_ID('sp_busca_tree_itempeca','p') IS NOT NULL
		DROP PROCEDURE sp_busca_tree_itempeca;
GO

CREATE PROCEDURE sp_busca_tree_itempeca  
@id_item INT  
AS  
SELECT p.id_peca_real, ip.id_peca, ip.dat_alt, ip.flg_ativo, ip.id_item, ip.qtd_peca  
FROM itempeca ip inner join peca p  
on ip.id_peca = p.id_peca  
WHERE ip.id_item = @id_item  
AND ip.flg_ativo = 1  
  
-- exec sp_busca_tree_itempeca 1  
