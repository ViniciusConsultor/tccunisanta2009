CREATE PROCEDURE sp_busca_id
@nome_tabela varchar(50),
@id_tabela varchar(50)
AS
SELECT MAX(@id_tabela) from @nome_tabela