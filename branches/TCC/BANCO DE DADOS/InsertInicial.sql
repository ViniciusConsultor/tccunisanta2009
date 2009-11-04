USE Megatechdatabase
go

INSERT TABELA DEPARTAMENTO
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, flg_ativo) VALUES (1, 'DEPARTAMENTO 1', GETDATE(), 1);
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, flg_ativo) VALUES (2, 'DEPARTAMENTO 2', GETDATE(), 1);
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, flg_ativo) VALUES (3, 'DEPARTAMENTO 3', GETDATE(), 1);

--INSERT TABELA TIPO_DE_USUÁRIO
--INSERT INTO Tipousuario (id_tipo_usuario, dsc_tipo_usuario) VALUES (1, 'ADM');

--INSERT TABELA USUARIO
INSERT INTO Usuario (id_usu, id_perfil, log_usu, senha, obs_usu, flg_ativo) VALUES (1, 1, 'kaue', '123', 'SEI LA', 1);

--INSERT TABELA ESTADO
INSERT INTO Estado (slg_est, nom_est) VALUES ('AC', 'ACRE');
INSERT INTO Estado (slg_est, nom_est) VALUES ('AL', 'ALAGOAS');
INSERT INTO Estado (slg_est, nom_est) VALUES ('AP', 'AMAPÁ');
INSERT INTO Estado (slg_est, nom_est) VALUES ('AM', 'AMAZONAS');
INSERT INTO Estado (slg_est, nom_est) VALUES ('BA', 'BAHIA');
INSERT INTO Estado (slg_est, nom_est) VALUES ('CE', 'CEARÁ');
INSERT INTO Estado (slg_est, nom_est) VALUES ('DF', 'DISTRITO FEDERAL');
INSERT INTO Estado (slg_est, nom_est) VALUES ('ES', 'ESPÍRITO SANTO');
INSERT INTO Estado (slg_est, nom_est) VALUES ('GO', 'GOIÁS');
INSERT INTO Estado (slg_est, nom_est) VALUES ('MA', 'MARANHÃO');
INSERT INTO Estado (slg_est, nom_est) VALUES ('MT', 'MATO GROSSO');
INSERT INTO Estado (slg_est, nom_est) VALUES ('MS', 'MATO GROSSO DO SUL');
INSERT INTO Estado (slg_est, nom_est) VALUES ('MG', 'MINAS GERAIS');
INSERT INTO Estado (slg_est, nom_est) VALUES ('PA', 'PARÁ');
INSERT INTO Estado (slg_est, nom_est) VALUES ('PB', 'PARAÍBA');
INSERT INTO Estado (slg_est, nom_est) VALUES ('PR', 'PARANÁ');
INSERT INTO Estado (slg_est, nom_est) VALUES ('PE', 'PERNAMBUCO');
INSERT INTO Estado (slg_est, nom_est) VALUES ('PI', 'PIAUÍ');
INSERT INTO Estado (slg_est, nom_est) VALUES ('RJ', 'RIO DE JANEIRO');
INSERT INTO Estado (slg_est, nom_est) VALUES ('RN', 'RIO GRANDE DO NORTE');
INSERT INTO Estado (slg_est, nom_est) VALUES ('RS', 'RIO GRANDE DO SUL');
INSERT INTO Estado (slg_est, nom_est) VALUES ('RO', 'RONDÔNIA');
INSERT INTO Estado (slg_est, nom_est) VALUES ('RR', 'RORAIMA');
INSERT INTO Estado (slg_est, nom_est) VALUES ('SC', 'SANTA CATARINA');
INSERT INTO Estado (slg_est, nom_est) VALUES ('SP', 'SÃO PAULO');
INSERT INTO Estado (slg_est, nom_est) VALUES ('SE', 'SERGIPE');
INSERT INTO Estado (slg_est, nom_est) VALUES ('TO', 'TOCANTINS');


--INSERT TABELA COLABORADOR
INSERT INTO Colaborador (id_colab, nom, dat_nasc, rua, nro_ende, compl, cep, bairr, ddd, cid, tel, rg, cpf, sex, mail, dat_atl, flg_ativo, id_usu, id_depto, slg_est) VALUES (1, 'Kaue', '1988-06-02', 'Av. Ana Costa', 516, 'Sem Complemento', '11060002', 'Gonzaga', 13, 'Santos', '38828678', '321452015120321', '145266987125012', 'M', 'kauepaulo@hotmail.com', GETDATE(), 1, 1, 1, 'SP');

INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Venda', NULL, GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Estoque', 'frmCadEstoque', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Produção', NULL, GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Compra', NULL, GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Cadastro', NULL, GETDATE(), 1);

INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Cliente', 'frmCadCliente', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Pedido Venda', 'frmCadPedidoVenda', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Venda', 'frmCadVenda', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Colaborador', 'frmCadColaborador', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Usinagem', 'frmCadUsinagem', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Motor', NULL, GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Tipo de Motor', 'frmCadTipoMotor', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Familia do Motor', 'frmCadFamiliaMotor', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Número Motor', 'frmCadNumeroMotor', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Motor', 'frmCadMotor', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Ordem Produção', 'frmCadOrdemProducao', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Tipo Produto', 'frmCadTipoProduto', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Peça', NULL, GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Kit Grupo Peça', 'frmCadKitGrupoPeca', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Tipo Peça', 'frmCadTipoPeca', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Peça', 'frmCadPeca', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Compra Peça', 'frmCadCompraPeca', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Compra', 'frmCadCompra', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Fornecedor', 'frmCadFornecedor', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Peça Fornecedor', 'frmCadPecaFornecedor', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Usuário', 'frmCadUsuario', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Cliente', 'frmCadCliente', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Colaborador', 'frmCadColaborador', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Departamento', 'frmCadDepartamento', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Item Peça', 'frmCadItemPeca', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Peça Fornecedor', 'frmCadPecaFornecedor', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Perfil Menu', 'frmCadPerfilMenu', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Perfil', 'frmCadPerfil', GETDATE(), 1);

--Venda !!
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (1, 7);--Pedido Venda
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (1, 8);--Venda
--Estoque

--Produção
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 10);--Usinagem
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 11);--Motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 16);--Ordem Produção
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 17);--Tipo Produto
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 18);--Peça
--Motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (11, 12);--Tipo de Motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (11, 13);--Familia do Motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (11, 14);--Número Motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (11, 15);--Motor
--Peça
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (18, 19);--Kit Grupo Peça
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (18, 20);--Tipo Peça
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (18, 21);--Tipo Peça
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (18, 30);--Item Peça
--INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 31);--Peça Fornecedor

--Compra
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (4, 22);--Compra Peça
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (4, 23);--Compra

--Cadastro
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 24);--Fornecedor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 25);--Peça Fornecedor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 26);--Usuário
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 27);--Cliente
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 28);--Colaborador
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 29);--Departamento
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 32);--Perfil Menu
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 33);--Perfil

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

--INSERT TABELA CLIENTE 
INSERT INTO cliente (id_cli, nom,tel,rua,nro_ende,compl,cep,bairr,cid,dat_atl,flg_ativo,slg_est,mail,ddd,cpf,cnpj) VALUES (1, 'julio','32322970','baralho',666,'castelo','11111111','Iron Forge','Storm Wind',GETDATE(),1,'SP','wow@mail.com',99,'37006765811',null )