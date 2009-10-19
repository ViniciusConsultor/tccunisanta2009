Use Megatechdatabase

INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (1, 'Venda', NULL, GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (2, 'Estoque', 'frmCadEstoque', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (3, 'Produção', NULL, GETDATE(), 1);
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
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (14, 'Número Motor', 'frmCadNumeroMotor', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (15, 'Motor', 'frmCadMotor', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (16, 'Ordem Produção', 'frmCadOrdemProducao', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (17, 'Tipo Produto', 'frmCadTipoProduto', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (18, 'Peça', NULL, GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (19, 'Kit Grupo Peça', 'frmCadKitGrupoPeca', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (20, 'Tipo Peça', 'frmCadTipoPeca', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (21, 'Peça', 'frmCadPeca', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (22, 'Compra Peça', 'frmCadCompraPeca', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (23, 'Compra', 'frmCadCompra', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (24, 'Fornecedor', 'frmCadFornecedor', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (25, 'Peça Fornecedor', 'frmCadPecaFornecedor', GETDATE(), 1);
INSERT INTO Menu (id_menu, dsc_menu, ende, dat_atl, flg_ativo) VALUES (26, 'Usuário', 'frmCadUsuario', GETDATE(), 1);

--Venda !!
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (1, 7);--Pedido Venda
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (1, 8);--Venda
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 12);--Tipo de Motor
--Estoque

--Produção
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 10);--Usinagem
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 11);--Motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 16);--Ordem Produção
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (3, 17);--Tipo Produto
--Motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (11, 12);--Tipo de Motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (11, 13);--Familia do Motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (11, 14);--Número Motor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (11, 15);--Motor
--Peça
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (18, 19);--Kit Grupo Peça
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (18, 20);--Tipo Peça
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (18, 21);--Tipo Peça

--Compra
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (4, 22);--Compra Peça
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (4, 23);--Compra

--Cadastro
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 24);--Fornecedor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 25);--Peça Fornecedor
INSERT INTO Submenu (id_menu_pai, id_menu_filho) VALUES (5, 26);--Usuário