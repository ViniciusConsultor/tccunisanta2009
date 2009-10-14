USE Megatechdatabase
go

--INSERT TABELA DEPARTAMENTO
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, flg_ativo) VALUES (1, 'DEPARTAMENTO 1', GETDATE(), 1);
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, flg_ativo) VALUES (2, 'DEPARTAMENTO 2', GETDATE(), 1);
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, flg_ativo) VALUES (3, 'DEPARTAMENTO 3', GETDATE(), 1);

--INSERT TABELA TIPO_DE_USU�RIO
--INSERT INTO Tipousuario (id_tipo_usuario, dsc_tipo_usuario) VALUES (1, 'ADM');

--INSERT TABELA USUARIO
INSERT INTO Usuario (id_usu, login, senha, obs_usu, flg_ativo) VALUES (1, 'kaue', '123', 'SEI LA', 1);

--INSERT TABELA ESTADO
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('AC', 'ACRE');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('AL', 'ALAGOAS');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('AP', 'AMAP�');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('AM', 'AMAZONAS');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('BA', 'BAHIA');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('CE', 'CEAR�');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('DF', 'DISTRITO FEDERAL');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('ES', 'ESP�RITO SANTO');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('GO', 'GOI�S');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('MA', 'MARANH�O');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('MT', 'MATO GROSSO');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('MS', 'MATO GROSSO DO SUL');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('MG', 'MINAS GERAIS');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('PA', 'PAR�');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('PB', 'PARA�BA');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('PR', 'PARAN�');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('PE', 'PERNAMBUCO');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('PI', 'PIAU�');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('RJ', 'RIO DE JANEIRO');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('RN', 'RIO GRANDE DO NORTE');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('RS', 'RIO GRANDE DO SUL');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('RO', 'ROND�NIA');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('RR', 'RORAIMA');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('SC', 'SANTA CATARINA');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('SP', 'S�O PAULO');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('SE', 'SERGIPE');
INSERT INTO Estado (slg_estado, nom_estado) VALUES ('TO', 'TOCANTINS');


--INSERT TABELA COLABORADOR
INSERT INTO Colaborador (id_colab, nom_colab, dat_nasc, nom_rua, nro_end, compl_end, cep, bairr_end, ddd_colab, cidade, tel_colab, rg, cpf, sexo, email_colab, dat_atl, flg_ativo, id_usu, id_depto, slg_estado) VALUES (1, 'Kaue', '1988-06-02', 'Av. Ana Costa', 516, 'Sem Complemento', '11060002', 'Gonzaga', 13, 'Santos', '38828678', '321452015120321', '145266987125012', 'M', 'kauepaulo@hotmail.com', GETDATE(), 1, 1, 1, 'SP');

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
INSERT INTO Submenu (id_sub, dsc_sub, end_sub, dat_atl, flg_ativo) VALUES (8, 'COMPRA',	  'frmCadCompra', GETDATE(), 1);
INSERT INTO Submenu (id_sub, dsc_sub, end_sub, dat_atl, flg_ativo) VALUES (9, 'MOTOR',	  'frmCadMotor', GETDATE(), 1);
INSERT INTO Submenu (id_sub, dsc_sub, end_sub, dat_atl, flg_ativo) VALUES (10, 'TIPO PE�A',	  'frmCadTipoPeca', GETDATE(), 1);
INSERT INTO Submenu (id_sub, dsc_sub, end_sub, dat_atl, flg_ativo) VALUES (11, 'ESTOQUE',	  'frmCadEstoque', GETDATE(), 1);
INSERT INTO Submenu (id_sub, dsc_sub, end_sub, dat_atl, flg_ativo) VALUES (12, 'PE�A',	  'frmCadPeca', GETDATE(), 1);

--INSERT TABELA MENUSUBMENU
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 1, GETDATE(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 2, GETDATE(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 3, GETDATE(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 4, GETDATE(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 5, GETDATE(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 6, getdate(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 7, getdate(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 8, getdate(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 9, getdate(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 10, getdate(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 11, getdate(), 1);
INSERT INTO Menusubmenu (id_menu, id_sub, dat_trans, flg_ativo) VALUES (1, 12, getdate(), 1);

--INSERT TABELA PERFILMENU
INSERT INTO Perfilmenu (id_perfil, id_menu, dat_trans, flg_ativo) VALUES (1, 1, GETDATE(), 1);
INSERT INTO Perfilmenu (id_perfil, id_menu, dat_trans, flg_ativo) VALUES (1, 2, GETDATE(), 1);