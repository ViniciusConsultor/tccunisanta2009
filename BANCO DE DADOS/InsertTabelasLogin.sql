USE Megatechdatabase
go

--INSERT TABELA DEPARTAMENTO
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, flg_ativo) VALUES (1, 'DEPARTAMENTO 1', GETDATE(), 1);
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, flg_ativo) VALUES (2, 'DEPARTAMENTO 2', GETDATE(), 1);
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, flg_ativo) VALUES (3, 'DEPARTAMENTO 3', GETDATE(), 1);

--INSERT TABELA TIPO_DE_USUÁRIO
--INSERT INTO Tipousuario (id_tipo_usuario, dsc_tipo_usuario) VALUES (1, 'ADM');

--INSERT TABELA USUARIO
INSERT INTO Usuario (id_usu, login, senha, obs_usu, flg_ativo) VALUES (1, 'kaue', '123', 'SEI LA', 1);

--INSERT TABELA ESTADO
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (1, 'AC', 'ACRE');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (2, 'AL', 'ALAGOAS');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (3, 'AP', 'AMAPÁ');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (4, 'AM', 'AMAZONAS');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (5, 'BA', 'BAHIA');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (6, 'CE', 'CEARÁ');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (7, 'DF', 'DISTRITO FEDERAL');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (8, 'ES', 'ESPÍRITO SANTO');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (9, 'GO', 'GOIÁS');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (10, 'MA', 'MARANHÃO');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (11, 'MT', 'MATO GROSSO');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (12, 'MS', 'MATO GROSSO DO SUL');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (13, 'MG', 'MINAS GERAIS');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (14, 'PA', 'PARÁ');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (15, 'PB', 'PARAÍBA');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (16, 'PR', 'PARANÁ');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (17, 'PE', 'PERNAMBUCO');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (18, 'PI', 'PIAUÍ');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (19, 'RJ', 'RIO DE JANEIRO');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (20, 'RN', 'RIO GRANDE DO NORTE');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (21, 'RS', 'RIO GRANDE DO SUL');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (22, 'RO', 'RONDÔNIA');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (23, 'RR', 'RORAIMA');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (24, 'SC', 'SANTA CATARINA');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (25, 'SP', 'SÃO PAULO');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (26, 'SE', 'SERGIPE');
INSERT INTO Estado (id_estado, slg_estado, nom_estado) VALUES (27, 'TO', 'TOCANTINS');


--INSERT TABELA COLABORADOR
INSERT INTO Colaborador (id_colab, nom_colab, dat_nasc, nom_rua, nro_end, compl_end, cep, bairr_end, cidade, rg, cpf, sexo, dat_atl, flg_ativo, id_usu, id_depto, id_estado) VALUES (1, 'Kaue', '1988-06-02', 'Av. Ana Costa', 516, 'Sem Complemento', '11060002', 'Gonzaga', 'Santos', '321452015120321', '145266987125012', 'M', GETDATE(), 1, 1, 1, 25);

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
INSERT INTO Submenu (id_sub, dsc_sub, end_sub, dat_atl, flg_ativo) VALUES (5, 'PERFIL MENU',  'frmCadPerfilMenu', GETDATE(), 1);
INSERT INTO Submenu (id_sub, dsc_sub, end_sub, dat_atl, flg_ativo) VALUES (6, 'FORNECEDOR',   'frmCadFornecedor', GETDATE(), 1);
INSERT INTO Submenu (id_sub, dsc_sub, end_sub, dat_atl, flg_ativo) VALUES (7, 'CLIENTE',	  'frmCadCliente', GETDATE(), 1);

--INSERT TABELA MENUSUBMENU
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 1, GETDATE(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 2, GETDATE(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 3, GETDATE(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 4, GETDATE(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 5, GETDATE(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 6, getdate(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 7, getdate(), 1);

--INSERT TABELA PERFILMENU
INSERT INTO Perfilmenu (id_perfil, id_menu, dat_trans, flg_ativo) VALUES (1, 1, GETDATE(), 1);
INSERT INTO Perfilmenu (id_perfil, id_menu, dat_trans, flg_ativo) VALUES (1, 2, GETDATE(), 1);