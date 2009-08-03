CREATE PROCEDURE sp_insert_menu
@id_menu INT,
@dsc_menu VARCHAR(50),
@end_menu VARCHAR(500),
@dat_atl DATETIME,
@flg_ativo BIT
AS
INSERT INTO Menu(id_menu, dsc_menu, end_menu, dat_atl, flg_ativo)
VALUES (@id_menu, @dsc_menu, @end_menu, @dat_atl, @flg_ativo)