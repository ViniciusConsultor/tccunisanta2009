USE Megatechdatabase
go

--INSERT TABELA ESTADO
INSERT INTO Estado (slg_est, nom_est) VALUES ('AC', 'ACRE');
INSERT INTO Estado (slg_est, nom_est) VALUES ('AL', 'ALAGOAS');
INSERT INTO Estado (slg_est, nom_est) VALUES ('AP', 'AMAP�');
INSERT INTO Estado (slg_est, nom_est) VALUES ('AM', 'AMAZONAS');
INSERT INTO Estado (slg_est, nom_est) VALUES ('BA', 'BAHIA');
INSERT INTO Estado (slg_est, nom_est) VALUES ('CE', 'CEAR�');
INSERT INTO Estado (slg_est, nom_est) VALUES ('DF', 'DISTRITO FEDERAL');
INSERT INTO Estado (slg_est, nom_est) VALUES ('ES', 'ESP�RITO SANTO');
INSERT INTO Estado (slg_est, nom_est) VALUES ('GO', 'GOI�S');
INSERT INTO Estado (slg_est, nom_est) VALUES ('MA', 'MARANH�O');
INSERT INTO Estado (slg_est, nom_est) VALUES ('MT', 'MATO GROSSO');
INSERT INTO Estado (slg_est, nom_est) VALUES ('MS', 'MATO GROSSO DO SUL');
INSERT INTO Estado (slg_est, nom_est) VALUES ('MG', 'MINAS GERAIS');
INSERT INTO Estado (slg_est, nom_est) VALUES ('PA', 'PAR�');
INSERT INTO Estado (slg_est, nom_est) VALUES ('PB', 'PARA�BA');
INSERT INTO Estado (slg_est, nom_est) VALUES ('PR', 'PARAN�');
INSERT INTO Estado (slg_est, nom_est) VALUES ('PE', 'PERNAMBUCO');
INSERT INTO Estado (slg_est, nom_est) VALUES ('PI', 'PIAU�');
INSERT INTO Estado (slg_est, nom_est) VALUES ('RJ', 'RIO DE JANEIRO');
INSERT INTO Estado (slg_est, nom_est) VALUES ('RN', 'RIO GRANDE DO NORTE');
INSERT INTO Estado (slg_est, nom_est) VALUES ('RS', 'RIO GRANDE DO SUL');
INSERT INTO Estado (slg_est, nom_est) VALUES ('RO', 'ROND�NIA');
INSERT INTO Estado (slg_est, nom_est) VALUES ('RR', 'RORAIMA');
INSERT INTO Estado (slg_est, nom_est) VALUES ('SC', 'SANTA CATARINA');
INSERT INTO Estado (slg_est, nom_est) VALUES ('SP', 'S�O PAULO');
INSERT INTO Estado (slg_est, nom_est) VALUES ('SE', 'SERGIPE');
INSERT INTO Estado (slg_est, nom_est) VALUES ('TO', 'TOCANTINS');

--INSERT MENU

INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (1, 'Compra', NULL, GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (2, 'Venda', NULL, GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (3, 'Estoque', NULL, GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (4, 'Produ��o', NULL, GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (5, 'Cadastros', NULL, GETDATE(), 1);

--INSERT BUSCAS 
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (6, 'Pe�as', NULL, GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (7, 'Itens', NULL, GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (8, 'Kit de Pe�as', NULL, GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (9, 'Familia de Motores', NULL, GETDATE(), 1);

--INSERT COMPRA 1
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (10, 'Fornecedores', NULL, GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (11, 'Cadastrar Fornecedores', 'frmCadFornecedor', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (12, 'Relacionar Pe�as ao Fornecedor',NULL , GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (13, 'Realizar Compra', 'frmCadCompra', GETDATE(), 1);

--INSERT VENDA 2
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (14, 'Cadastrar Produtos', NULL, GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (15, 'Cadastrar Clientes', 'frmCadCliente', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (16, 'Realizar Venda', 'frmCadVenda', GETDATE(), 1);

--INSERT ESTOQUE 3
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (17, 'Cadastrar estoques', 'frmCadEstoque', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (18, 'Movimenta��o de Pe�as', 'frmCadPecaEstoque', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (19, 'Buscas', NULL, GETDATE(), 1);

--INSERT PRODU��O 4
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (20, 'Busca Pe�as', NULL, GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (21, 'Tipo de Pe�a', 'frmCadTipoPeca', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (22, 'Informar Usinagem', 'frmCadUsinagem', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (23, 'Cadastrar Pe�as', 'frmCadPeca', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (24, 'Cadastrar Itens', 'frmCadItem', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (25, 'Cadastrar Kits', 'frmCadKitGrupoPeca', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (26, 'Motores', NULL, GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (27, 'Cadastrar Tipo de Motor', 'frmCadTipoMotor', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (28, 'Cadastrar N�mero Motor', 'frmCadNumeroMotor', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (29, 'Cadastrar Motor',	NULL , GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (30, 'Cadastrar Familia de Motores', 'frmCadFamiliaMotor', GETDATE(), 1);

--INSERT CADASTRO GERAIS 5
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (31, 'Cadastrar Departamentos ', 'frmCadDepartamento', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (32, 'Usuarios', NULL, GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (33, 'Cadastrar Perfis', 'frmCadPerfil', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (34, 'Cadastrar Funcion�rio ', 'frmCadColaborador', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (35, 'Relacionar Menus ao Perfil', 'frmPerfilMenu', GETDATE(), 1);



--COMPRA
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (1, 10);--fornecedor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (10, 11);--fornecedor/cadforn..
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (10, 12);--fornecedor--pe�a/forn
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (1, 13);--forneceodor/ Realiza compra

--VENDA
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (2, 14);--cadVEnda
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (2, 15);--CadCliente
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (2, 16);--RealizaVenda

--ESTOQUE
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 17);--cadastro estoque
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 18);--Movimenta Pe�a
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 19);--Estoque/Busca
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (19, 20);--BuscaPe�a
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (19, 7);--Busca Item
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (19, 8);--kit
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (19, 9);--Busca Familia motor

--PRODU��O
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (6, 21);--pe�as/tipo peca
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (6, 22);--pe�as/informar usinagem
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (6, 23);--pe�as/cadastro pe�a
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (4, 6);--produ��o/pe�a
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (4, 24);--cadastra item pe�a
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (4, 25);--cadastra kit
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (4, 26);--produ��o/motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (26, 27);--motores/tipo motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (26, 28);--motores/numero motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (26, 29);--motores/cadastro motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (26, 30);--motores/familha motor

--CADASTROS
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 31);--cad departamento
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 32);--cadastro/usuario
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (32, 33);--usuario/cad perfil
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (32, 34);--usuario/cad funcionario
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (32, 35);--usuario/relacionaperfilmenu

--INSERT TABELA PERFIL
INSERT INTO Perfil (id_perfil, dsc_perfil, dat_atl, flg_ativo) VALUES (1, 'DEFAULT', GETDATE(), 1);

--INSERT TABELA PERFILMENU
INSERT INTO Perfilmenu (id_perfil, id_menu, dat_alt, flg_ativo) VALUES (1, 1, GETDATE(), 1);
INSERT INTO Perfilmenu (id_perfil, id_menu, dat_alt, flg_ativo) VALUES (1, 2, GETDATE(), 1);
INSERT INTO Perfilmenu (id_perfil, id_menu, dat_alt, flg_ativo) VALUES (1, 3, GETDATE(), 1);
INSERT INTO Perfilmenu (id_perfil, id_menu, dat_alt, flg_ativo) VALUES (1, 4, GETDATE(), 1);
INSERT INTO Perfilmenu (id_perfil, id_menu, dat_alt, flg_ativo) VALUES (1, 5, GETDATE(), 1);


--INSERT TABELA TIPOPRODUTO
INSERT INTO Tipoproduto (nom, flg_ativo, dat_alt) VALUES ('Motor', 1, GETDATE());
INSERT INTO Tipoproduto (nom, flg_ativo, dat_alt) VALUES ('Kit', 1, GETDATE());

--INSERT TABELA USUARIO senha: 123
INSERT INTO Usuario (id_usu, log_usu, senha, obs_usu, flg_ativo, id_perfil) VALUES (1, 'kaue', 'MTIz', 'SEI LA', 1, 1);
--fornecedor
INSERT INTO Fornecedor( id_forn, nom, rua, nro_ende, compl, cod_post, ddd, bairr, tel, cid, mail, cnpj, dat_alt, flg_ativo, slg_est, nom_pais, nom_est_inter)VALUES (1,'Pe�as & Equips', 'Dom Bosco', 357,'Apartamento', 11070098, 33, 'Vila Nova', 56985880, 'Manaus', 'pe�asequips@mail.com','123468579', GETDATE(), 1, 'am', 'Brasil', NULL);
INSERT INTO Fornecedor( id_forn, nom, rua, nro_ende, compl, cod_post, ddd, bairr, tel, cid, mail, cnpj, dat_alt, flg_ativo, slg_est, nom_pais, nom_est_inter)VALUES (2,'Mercedes', 'Vinicius de Morais', 1085,'casa', 11070000, 25, 'Rio de Janeiro', 56556680, 'Rio de aneiro', 'bwm@mail.com','123468579', GETDATE(), 1, 'rj', 'Brasil', NULL);

--Numero Motor
INSERT INTO Numeromotor(id_num_motor ,id_num_motor_real ,dsc_num_motor ,flg_ativo) VALUES (1,'366','Default' , 1);
INSERT INTO Numeromotor(id_num_motor ,id_num_motor_real ,dsc_num_motor ,flg_ativo) VALUES (2,'447','Moto Bomba' ,1);

--TipoMotor
INSERT INTO Tipomotor(id_tipo_motor ,id_tipo_motor_real ,dsc_tipo_motor ,flg_ativo) VALUES (1,'LA', 'Turbo Aspirado', 1);
INSERT INTO Tipomotor(id_tipo_motor ,id_tipo_motor_real ,dsc_tipo_motor ,flg_ativo) VALUES (2,'A', 'Aspirado', 1);

--kitGrupoPeca
INSERT INTO Kitgrupopeca(id_kit, id_kit_real,nom, flg_ativo,dat_alt) VALUES (1 ,'014', 'KIT 366 LA',1,GETDATE());
INSERT INTO Kitgrupopeca(id_kit, id_kit_real,nom, flg_ativo,dat_alt) VALUES (2 ,'015', 'KIT 447 A',1,GETDATE());

--tipo peca
INSERT INTO tipoPeca(id_tipo_peca,dsc_tipo_peca,flg_ativo)VALUES(1,'Pequenas',1);
INSERT INTO tipoPeca(id_tipo_peca,dsc_tipo_peca,flg_ativo)VALUES(2,'rosquiaveis',1);

--Pe�as
INSERT INTO Peca( id_peca,id_peca_real ,nom ,dat_alt ,peso ,flg_ativo ,dsc_peca,qtd_min,id_tipo_peca) VALUES (1 ,'0.0', 'Solen�ide', GETDATE() , 1.0, 1, 'SOLEN�IDE DO MOTOR 366 LA',5, 1 );
INSERT INTO Peca( id_peca,id_peca_real ,nom ,dat_alt ,peso ,flg_ativo ,dsc_peca,qtd_min,id_tipo_peca) VALUES (2 ,'1.0', 'Porca', GETDATE() , 0.1, 1, 'PORCA DO MOTOR 366 LA',10, 2 );
INSERT INTO Peca( id_peca,id_peca_real ,nom ,dat_alt ,peso ,flg_ativo ,dsc_peca,qtd_min,id_tipo_peca) VALUES (3 ,'0.0', 'Filtro de Ar', GETDATE() , 0.5, 1, 'FILTRO DE AR  DO MOTOR 447 A',8, 1 );
INSERT INTO Peca( id_peca,id_peca_real ,nom ,dat_alt ,peso ,flg_ativo ,dsc_peca,qtd_min,id_tipo_peca) VALUES (4 ,'0.0', 'Solen�ide de Parada', GETDATE() , 1.0, 1, 'SOLEN�IDE DE PARADA DO MOTOR 447 A',6, 1 );

--DEPARTAMENTO
INSERT INTO Departamento (id_depto,dsc_depto ,dat_atl,nom ,flg_ativo) 	VALUES (1 ,'estoque de pe�as',GETDATE() , 'Almoxarifado', 1);
INSERT INTO Departamento (id_depto,dsc_depto ,dat_atl,nom ,flg_ativo) 	VALUES (2 ,'ajuste de pe�as brutas',GETDATE() , 'Usinagem', 1);
INSERT INTO Departamento (id_depto,dsc_depto ,dat_atl,nom ,flg_ativo) 	VALUES (3 ,'linha de montagem',GETDATE() , 'Produ��o', 1);

--Estoque
INSERT INTO Estoque (id_estoq, dsc_estoq,dat_alt , flg_ativo, id_depto, flg_negativo) VALUES (1 ,'Estoque do almoxarifado', GETDATE() , 1 , 1 ,0);
INSERT INTO Estoque (id_estoq, dsc_estoq,dat_alt , flg_ativo, id_depto, flg_negativo) VALUES (2 ,'Estoque da Usinagem', GETDATE() , 1 , 2 ,0);
INSERT INTO Estoque (id_estoq, dsc_estoq,dat_alt , flg_ativo, id_depto, flg_negativo) VALUES (3 ,'Estoque da Produ��o', GETDATE() , 1 , 3 ,0);
INSERT INTO Estoque (id_estoq, dsc_estoq,dat_alt , flg_ativo, id_depto, flg_negativo) VALUES (4 ,'Estoque do Pe�as Defeituosas', GETDATE() , 1 , 2 ,0);

--item 
INSERT INTO Item (id_item, nom, flg_ativo, id_item_real, dat_alt)VALUES ( 1,'Bomba Dagua' ,1 ,'1.' ,GETDATE());
INSERT INTO Item (id_item, nom, flg_ativo, id_item_real, dat_alt)VALUES ( 2,'Bomba Dagua' ,1 ,'2.' ,GETDATE());
INSERT INTO Item (id_item, nom, flg_ativo, id_item_real, dat_alt)VALUES ( 3,'Bomba Dagua' ,1 ,'3.' ,GETDATE());

--colaborador
INSERT INTO Colaborador(id_colab, nom, dat_nasc, rua, nro_ende, compl, cep, bairr, ddd, cid, tel, rg, cpf, sex, mail, dat_atl, flg_ativo, id_usu, id_depto, slg_est)VALUES (1, 'Andre',1982-05-04, 'Carvalho de Mendon�a', 478, 'Casa', 11070102, 'Vila Belmiro', 13, 'Santos', 32398027, 441014227, 37006765811, 'M', 'andre@mail.com', GETDATE(), 1, 1,3,'SP');


