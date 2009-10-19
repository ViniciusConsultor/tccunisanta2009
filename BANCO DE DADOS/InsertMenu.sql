Use Megatechdatabase

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

--Venda !!
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (1, 7);--Pedido Venda
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (1, 8);--Venda
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 12);--Tipo de Motor
--Estoque

--Produ��o
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 10);--Usinagem
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 11);--Motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 16);--Ordem Produ��o
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 17);--Tipo Produto
--Motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (11, 12);--Tipo de Motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (11, 13);--Familia do Motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (11, 14);--N�mero Motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (11, 15);--Motor
--Pe�a
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (18, 19);--Kit Grupo Pe�a
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (18, 20);--Tipo Pe�a
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (18, 21);--Tipo Pe�a

--Compra
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (4, 22);--Compra Pe�a
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (4, 23);--Compra

--Cadastro
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 24);--Fornecedor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 25);--Pe�a Fornecedor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 26);--Usu�rio