USE Megatechdatabase
go

--INSERT TABELA DEPARTAMENTO
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, nom, flg_ativo) VALUES (1, 'DEPARTAMENTO 1', GETDATE(), 'Depto 01', 1);
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, nom, flg_ativo) VALUES (2, 'DEPARTAMENTO 2', GETDATE(), 'Depto 02', 1);
INSERT INTO Departamento (id_depto, dsc_depto, dat_atl, nom, flg_ativo) VALUES (3, 'DEPARTAMENTO 3', GETDATE(), 'Depto 03', 1);

--INSERT TABELA TIPO_DE_USUÁRIO
--INSERT INTO Tipousuario (id_tipo_usuario, dsc_tipo_usuario) VALUES (1, 'ADM');

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

--INSERT MENU
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Buscas', NULL, GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Compra', NULL, GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Venda', NULL, GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Estoque', NULL, GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Produção', NULL, GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Cadastros', NULL, GETDATE(), 1);

--INSERT BUSCAS 1
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Peças', NULL, GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Itens', NULL, GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Kit de Peças', NULL, GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Familia de Motores', NULL, GETDATE(), 1);

--INSERT COMPRA 2
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Fornecedores', NULL, GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Cadastrar Fornecedores', 'frmCadFornecedor', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Relacionar Peças ao Fornecedor',NULL , GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Realizar Compra', 'frmCadCompra', GETDATE(), 1);

--INSERT VENDA 3
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Cadastrar Produtos', NULL, GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Cadastrar Clientes', 'frmCadCliente', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Realizar Venda', 'frmCadVenda', GETDATE(), 1);

--INSERT ESTOQUE 4
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Cadastrar estoques', 'frmCadEstoque', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Movimentação de Peças', NULL, GETDATE(), 1);

--INSERT PRODUÇÃO 5
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Peças', NULL, GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Tipo de Peça', 'frmCadTipoPeca', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Informar Usinagem', 'frmCadUsinagem', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Cadastrar Peças', 'frmCadPeca', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Cadastrar Itens', 'frmCadItem', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Cadastrar Kits', 'frmCadKitGrupoPeca', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Motores', NULL, GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Cadastrar Tipo de Motor', 'frmCadTipoMotor', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Cadastrar Número Motor', 'frmCadNumeroMotor', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Cadastrar Motor', 'frmCadMotor', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Cadastrar Familia de Motores', 'frmCadFamiliaMotor', GETDATE(), 1);

--INSERT CADASTRO GERAIS 6
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Cadastrar Departamentos ', 'frmCadDepartamento', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Usuarios', NULL, GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Cadastrar Perfis', 'frmCadPerfil', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Cadastrar Funcionário ', 'frmCadColaborador', GETDATE(), 1);
INSERT INTO Menu (dsc_menu, ende, dat_atl, flg_ativo) VALUES ('Relacionar Menus ao Perfil', 'frmPerfilMenu', GETDATE(), 1);

--BUSCA
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (4, 1);--Estoque/Busca
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (1, 7);--BuscaPeça
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (1, 8);--Busca Item
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (1, 9);--kit
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (1, 10);--Busca Familia motor

--COMPRA
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (2, 11);--fornecedor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (11, 12);--fornecedor/cadforn..
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (11, 13);--fornecedor--peça/forn
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (2, 14);--forneceodor/ Realiza compra

--VENDA
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 15);--cadVEnda
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 16);--CadCliente
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 17);--RealizaVenda

--ESTOQUE
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (4, 18);--cadastro estoque
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (4, 19);--Movimenta Peça

--PRODUÇÃO
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (20, 21);--peças/tipo peca
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (20, 22);--peças/informar usinagem
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (20, 23);--peças/cadastro peça
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 20);--produção/peça
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 24);--cadastra item peça
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 25);--cadastra kit
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 26);--produção/motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (26, 27);--motores/tipo motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (26, 28);--motores/numero motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (26, 29);--motores/cadastro motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (26, 30);--motores/familha motor

--CADASTROS
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (6, 31);--cad departamento
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (6, 32);--cadastro/usuario
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
INSERT INTO Perfilmenu (id_perfil, id_menu, dat_alt, flg_ativo) VALUES (1, 6, GETDATE(), 1);

--INSERT TABELA TIPOPRODUTO
INSERT INTO Tipoproduto (nom, flg_ativo, dat_alt) VALUES ('Motor', 1, GETDATE());
INSERT INTO Tipoproduto (nom, flg_ativo, dat_alt) VALUES ('Kit', 1, GETDATE());

--INSERT TABELA USUARIO senha: 123
INSERT INTO Usuario (id_usu, log_usu, senha, obs_usu, flg_ativo, id_perfil) VALUES (1, 'kaue', 'MTIz', 'SEI LA', 1, 1);

--INSERT TABELA COLABORADOR
--INSERT INTO Colaborador (id_colab, nom, dat_nasc, rua, nro_ende, compl, cep, bairr, ddd, cid, tel, rg, cpf, sex, mail, dat_atl, flg_ativo, id_usu, id_depto, slg_est) VALUES (1, 'Kaue', '1988-06-02', 'Av. Ana Costa', 516, 'Sem Complemento', '11060002', 'Gonzaga', 13, 'Santos', '38828678', '321452015120321', '145266987125012', 'M', 'kauepaulo@hotmail.com', GETDATE(), 1, 1, 1, 'SP');

--INSERT TABELA CLIENTE 
--INSERT INTO cliente (id_cli, nom,tel,rua,nro_ende,compl,cep,bairr,cid,dat_atl,flg_ativo,slg_est,mail,ddd,cpf,cnpj, nom_pais) VALUES (1, 'julio','32322970','baralho',666,'castelo','11111111','Iron Forge','Storm Wind',GETDATE(),1,'SP','wow@mail.com',99,'37006765811',null, 'Brasil');
