USE Megatechdatabase
go

--INSERT TABELA DEPARTAMENTO
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, flg_ativo) VALUES (1, 'DEPARTAMENTO 1', GETDATE(), 1);
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, flg_ativo) VALUES (2, 'DEPARTAMENTO 2', GETDATE(), 1);
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, flg_ativo) VALUES (3, 'DEPARTAMENTO 3', GETDATE(), 1);

--INSERT TABELA TIPO_DE_USU�RIO
--INSERT INTO Tipousuario (id_tipo_usuario, dsc_tipo_usuario) VALUES (1, 'ADM');

--INSERT TABELA USUARIO
INSERT INTO Usuario (id_usu, log_usu, senha, obs_usu, flg_ativo) VALUES (1, 'kaue', '123', 'SEI LA', 1);

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


--INSERT TABELA COLABORADOR
INSERT INTO Colaborador (id_colab, nom, dat_nasc, rua, nro_ende, compl, cep, bairr, ddd, cid, tel, rg, cpf, sex, mail, dat_atl, flg_ativo, id_usu, id_depto, slg_est) VALUES (1, 'Kaue', '1988-06-02', 'Av. Ana Costa', 516, 'Sem Complemento', '11060002', 'Gonzaga', 13, 'Santos', '38828678', '321452015120321', '145266987125012', 'M', 'kauepaulo@hotmail.com', GETDATE(), 1, 1, 1, 'SP');

--INSERT TABELA PERFIL
INSERT INTO Perfil (id_perfil, dsc_perfil, dat_atl, flg_ativo) VALUES (1, 'DEFAULT', GETDATE(), 1);

INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (1, 'Venda', NULL, GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (2, 'Estoque', 'frmCadEstoque', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (3, 'Produ��o', NULL, GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (4, 'Compra', NULL, GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (5, 'Cadastro', NULL, GETDATE(), 1);

INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (6, 'Cliente', 'frmCadCliente', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (7, 'Pedido Venda', 'frmCadPedidoVenda', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (8, 'Venda', 'frmCadVenda', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (9, 'Colaborador', 'frmCadColaborador', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (10, 'Usinagem', 'frmCadUsinagem', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (11, 'Motor', NULL, GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (12, 'Tipo de Motor', 'frmCadTipoMotor', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (13, 'Familia do Motor', 'frmCadFamiliaMotor', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (14, 'N�mero Motor', 'frmCadNumeroMotor', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (15, 'Motor', 'frmCadMotor', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (16, 'Ordem Produ��o', 'frmCadOrdemProducao', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (17, 'Tipo Produto', 'frmCadTipoProduto', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (18, 'Pe�a', NULL, GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (19, 'Kit Grupo Pe�a', 'frmCadKitGrupoPeca', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (20, 'Tipo Pe�a', 'frmCadTipoPeca', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (21, 'Pe�a', 'frmCadPeca', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (22, 'Compra Pe�a', 'frmCadCompraPeca', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (23, 'Compra', 'frmCadCompra', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (24, 'Fornecedor', 'frmCadFornecedor', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (25, 'Pe�a Fornecedor', 'frmCadPecaFornecedor', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (26, 'Usu�rio', 'frmCadUsuario', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (27, 'Cliente', 'frmCadCliente', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (28, 'Colaborador', 'frmCadColaborador', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (29, 'Departamento', 'frmCadDepartamento', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (30, 'Item Pe�a', 'frmCadItemPeca', GETDATE(), 1);

--Venda !!
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (1, 7);--Pedido Venda
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (1, 8);--Venda
--Estoque

--Produ��o
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 10);--Usinagem
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 11);--Motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 16);--Ordem Produ��o
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 17);--Tipo Produto
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 18);--Pe�a
--Motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (11, 12);--Tipo de Motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (11, 13);--Familia do Motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (11, 14);--N�mero Motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (11, 15);--Motor
--Pe�a
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (18, 19);--Kit Grupo Pe�a
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (18, 20);--Tipo Pe�a
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (18, 21);--Tipo Pe�a
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (18, 30);--Item Pe�a

--Compra
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (4, 22);--Compra Pe�a
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (4, 23);--Compra

--Cadastro
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 24);--Fornecedor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 25);--Pe�a Fornecedor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 26);--Usu�rio
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 27);--Cliente
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 28);--Colaborador
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 29);--Departamento

--INSERT TABELA PERFILMENU
INSERT INTO Perfilmenu (id_perfil, id_menu, dat_alt, flg_ativo) VALUES (1, 1, GETDATE(), 1);
INSERT INTO Perfilmenu (id_perfil, id_menu, dat_alt, flg_ativo) VALUES (1, 2, GETDATE(), 1);
INSERT INTO Perfilmenu (id_perfil, id_menu, dat_alt, flg_ativo) VALUES (1, 3, GETDATE(), 1);
INSERT INTO Perfilmenu (id_perfil, id_menu, dat_alt, flg_ativo) VALUES (1, 4, GETDATE(), 1);
INSERT INTO Perfilmenu (id_perfil, id_menu, dat_alt, flg_ativo) VALUES (1, 5, GETDATE(), 1);

--INSERT TABELA CLIENTE 
INSERT INTO cliente (id_cli,nom,tel,rua,nro_ende,compl,cep,bairr,cid,rg,cnpj,dat_atl,flg_ativo,slg_est,mail,ddd) VALUES (1,'julio','32322970','baralho',666,'castelo','11111111','Iron Forge','Storm Wind',111111111,1111111,GETDATE(),1,'SP','wow@mail.com',99)