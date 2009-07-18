--INSERT TABELA DEPARTAMENTO
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, flg_ativo) VALUES (1, 'DEPARTAMENTO 1', GETDATE(), 1);
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, flg_ativo) VALUES (2, 'DEPARTAMENTO 2', GETDATE(), 1);
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, flg_ativo) VALUES (3, 'DEPARTAMENTO 3', GETDATE(), 1);

--INSERT TABELA USUARIO
INSERT INTO Usuario (id_usu, login, dsc_usu, senha, tipo, dsc_tipo, flg_admin, flg_ativo) VALUES (1, 'kaue', 'kaue', '123', '1', 'SEI LA', 1, 1);

--INSERT TABELA COLABORADOR
INSERT INTO Colaborador (id_colab, id_usu, id_depto, nom_colab, dat_nasc, nom_rua, nro_end, compl_end, cep, bairr_end, cidade, estado, rg, cpf, sexo, dat_atl, flg_ativo) VALUES (1, 1, 1, 'KAUE PAULO', '1988-06-02', 'AV. NAO FALO', 516, 'APTO HA', '12345678', 'HELL', 'BINAGUINHA DO NORTE', 'SP', '123456789', '11111111111', 'M', GETDATE(), 1);

--INSERT TABELA PERFIL
INSERT INTO Perfil (id_perfil, dsc_perfil, dat_atl, flg_ativo) VALUES (1, 'DEFAULT', GETDATE(), 1);

--INSERT TABELA MENU
INSERT INTO Menu (id_menu, dsc_menu, end_menu, dat_atl, flg_ativo) VALUES (1, 'CADASTROS', NULL, GETDATE(), 1);

--INSERT TABELA SUBMENU
INSERT INTO Submenu (id_sub, dsc_sub, end_sub, dat_atl, flg_ativo) VALUES (1, 'DEPARTAMENTO', NULL, GETDATE(), 1);
INSERT INTO Submenu (id_sub, dsc_sub, end_sub, dat_atl, flg_ativo) VALUES (2, 'USUARIO', NULL, GETDATE(), 1);
INSERT INTO Submenu (id_sub, dsc_sub, end_sub, dat_atl, flg_ativo) VALUES (3, 'COLABORADOR', NULL, GETDATE(), 1);
INSERT INTO Submenu (id_sub, dsc_sub, end_sub, dat_atl, flg_ativo) VALUES (4, 'PERFIL', NULL, GETDATE(), 1);

--INSERT TABELA MENUSUBMENU
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 1, GETDATE(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 2, GETDATE(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 3, GETDATE(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 4, GETDATE(), 1);

--INSERT TABELA PERFILMENU
INSERT INTO Perfilmenu (id_perfil, id_menu, dat_trans, flg_ativo) VALUES (1, 1, GETDATE(), 1);