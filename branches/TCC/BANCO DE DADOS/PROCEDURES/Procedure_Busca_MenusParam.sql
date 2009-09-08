CREATE PROCEDURE sp_busca_menusParam
@param VARCHAR(50)
AS
SELECT id_menu, dsc_menu FROM Menu WHERE dsc_menu like @param + '%'