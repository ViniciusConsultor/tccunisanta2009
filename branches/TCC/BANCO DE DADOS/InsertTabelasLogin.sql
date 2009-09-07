--INSERT TABELA DEPARTAMENTO
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, flg_ativo) VALUES (1, 'DEPARTAMENTO 1', GETDATE(), 1);
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, flg_ativo) VALUES (2, 'DEPARTAMENTO 2', GETDATE(), 1);
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, flg_ativo) VALUES (3, 'DEPARTAMENTO 3', GETDATE(), 1);

--INSERT TABELA TIPO_DE_USUÁRIO
INSERT INTO Tipousuario (id_tipo_usuario, dsc_tipo_usuario) VALUES (1, 'ADM');

--INSERT TABELA USUARIO
INSERT INTO Usuario (id_usu, login, senha, id_tipo_usuario, obs_usu, flg_ativo) VALUES (1, 'kaue', '123', 1, 'SEI LA', 1);

--INSERT TABELA ESTADO
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (1, 'SP', 'SÃO PAULO');

--INSERT TABELA COLABORADOR
INSERT INTO Colaborador (id_colab, nom_colab, dat_nasc, nom_rua, nro_end, compl_end, cep, bairr_end, cidade, rg, cpf, sexo, dat_atl, flg_ativo, id_usu, id_depto, id_estado) VALUES (1, 'Kaue', '1988-06-02', 'Av. Ana Costa', 516, 'Sem Complemento', '11060002', 'Gonzaga', 'Santos', '321452015120321', '145266987125012', 'M', GETDATE(), 1, 1, 1, 1);

--INSERT TABELA PERFIL
INSERT INTO Perfil (id_perfil, dsc_perfil, dat_atl, flg_ativo) VALUES (1, 'DEFAULT', GETDATE(), 1);

--INSERT TABELA MENU
INSERT INTO Menu (id_menu, dsc_menu, end_menu, dat_atl, flg_ativo) VALUES (1, 'CADASTROS', NULL, GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, end_menu, dat_atl, flg_ativo) VALUES (2, 'LOGIN', 'frmLogin', GETDATE(), 1);

--INSERT TABELA SUBMENU
INSERT INTO Submenu (id_sub, dsc_sub, end_sub, dat_atl, flg_ativo) VALUES (1, 'DEPARTAMENTO', 'frmCadDepartamento', GETDATE(), 1);
INSERT INTO Submenu (id_sub, dsc_sub, end_sub, dat_atl, flg_ativo) VALUES (2, 'USUARIO',	  'frmCadUsuario', GETDATE(), 1);
INSERT INTO Submenu (id_sub, dsc_sub, end_sub, dat_atl, flg_ativo) VALUES (3, 'COLABORADOR',  'frmCadColaborador', GETDATE(), 1);
INSERT INTO Submenu (id_sub, dsc_sub, end_sub, dat_atl, flg_ativo) VALUES (4, 'PERFIL',		  'frmCadPerfil', GETDATE(), 1);

--INSERT TABELA MENUSUBMENU
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 1, GETDATE(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 2, GETDATE(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 3, GETDATE(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 4, GETDATE(), 1);

--INSERT TABELA PERFILMENU
INSERT INTO Perfilmenu (id_perfil, id_menu, dat_trans, flg_ativo) VALUES (1, 1, GETDATE(), 1);
INSERT INTO Perfilmenu (id_perfil, id_menu, dat_trans, flg_ativo) VALUES (1, 2, GETDATE(), 1);