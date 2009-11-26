CREATE DATABASE Megatechdatabase
go

USE Megatechdatabase
go

IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Ordemservico')
DROP TABLE Ordemservico
go

CREATE TABLE Ordemservico (
       id_ordem_serv        int NOT NULL,
       id_venda             int NULL,
       id_compra            integer NULL
)
go


ALTER TABLE Ordemservico
       ADD PRIMARY KEY CLUSTERED (id_ordem_serv ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Motorestoque')
DROP TABLE Motorestoque
go

CREATE TABLE Motorestoque (
       id_estoq             integer NOT NULL,
       id_motor             integer NOT NULL,
       dat_alt              datetime NULL,
       qtd                  int NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Motorestoque
       ADD PRIMARY KEY CLUSTERED (id_estoq ASC, id_motor ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Compraordemcompra')
DROP TABLE Compraordemcompra
go

CREATE TABLE Compraordemcompra (
       id_compra            integer NOT NULL,
       id_ordem_compra      integer NOT NULL,
       dat_alt              datetime NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Compraordemcompra
       ADD PRIMARY KEY CLUSTERED (id_compra ASC, id_ordem_compra ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Vendaproduto')
DROP TABLE Vendaproduto
go

CREATE TABLE Vendaproduto (
       id_venda             int NOT NULL,
       flg_ativo            bit NULL,
       dat_alt              datetime NULL,
       qtd                  int NULL,
       id_prdto             integer NOT NULL
)
go


ALTER TABLE Vendaproduto
       ADD PRIMARY KEY CLUSTERED (id_venda ASC, id_prdto ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Ordemdepartamento')
DROP TABLE Ordemdepartamento
go

CREATE TABLE Ordemdepartamento (
       id_depto             integer NOT NULL,
       id_ordem             integer NOT NULL,
       flg_ativo            bit NULL,
       dat_alt              datetime NULL
)
go


ALTER TABLE Ordemdepartamento
       ADD PRIMARY KEY CLUSTERED (id_depto ASC, id_ordem ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Ordemcompra')
DROP TABLE Ordemcompra
go

CREATE TABLE Ordemcompra (
       id_peca              integer NOT NULL,
       ultim_preco          numeric(15,2) NULL,
       id_ordem_compra      integer NOT NULL,
       id_motor             integer NULL,
       dat_alt              datetime NULL,
       flg_ativo            bit NULL,
       nota_fisc            varchar(20) NULL,
       qtd                  int NOT NULL,
       id_forn              integer NULL
)
go


ALTER TABLE Ordemcompra
       ADD PRIMARY KEY CLUSTERED (id_ordem_compra ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Produto')
DROP TABLE Produto
go

CREATE TABLE Produto (
       id_prdto             integer NOT NULL,
       dsc_prdto            varchar(500) NULL,
       id_fam_motor         integer NULL,
       id_kit               integer NULL,
       id_tipo_produto      integer NOT NULL,
       flg_ativo            bit NULL,
       dat_alt              datetime NULL
)
go


ALTER TABLE Produto
       ADD PRIMARY KEY CLUSTERED (id_prdto ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Fornecedordepto')
DROP TABLE Fornecedordepto
go

CREATE TABLE Fornecedordepto (
       id_depto             integer NOT NULL,
       id_forn              integer NOT NULL,
       dat_alt              datetime NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Fornecedordepto
       ADD PRIMARY KEY CLUSTERED (id_depto ASC, id_forn ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Venda')
DROP TABLE Venda
go

CREATE TABLE Venda (
       id_cli               integer NOT NULL,
       dat_venda            datetime NULL,
       valor                numeric(15,2) NULL,
       nota_fisc            varchar(20) NULL,
       dat_saida            datetime NULL,
       id_venda             int NOT NULL
)
go


ALTER TABLE Venda
       ADD PRIMARY KEY CLUSTERED (id_venda ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Cliente')
DROP TABLE Cliente
go

CREATE TABLE Cliente (
       id_cli               integer NOT NULL,
       nom                  varchar(60) NOT NULL,
       tel                  integer NULL,
       rua                  varchar(100) NOT NULL,
       nro_ende             integer NOT NULL,
       compl                varchar(20) NULL,
       cod_post             varchar(20) NOT NULL,
       bairr                varchar(20) NOT NULL,
       cid                  varchar(50) NOT NULL,
       cpf                  varchar(15) NULL,
       dat_atl              datetime NULL,
       flg_ativo            bit NULL,
       mail                 varchar(100) NULL,
       ddd                  integer NULL,
       cnpj                 numeric(15) NULL,
       nom_est_inter        varchar(50) NULL,
       nom_pais             varchar(50) NOT NULL,
       slg_est              varchar(2) NULL,
       ident_inter          varchar(50) NULL,
       ddi                  char(4) NULL
)
go


ALTER TABLE Cliente
       ADD PRIMARY KEY CLUSTERED (id_cli ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Colaborador')
DROP TABLE Colaborador
go

CREATE TABLE Colaborador (
       id_colab             integer NOT NULL,
       nom                  varchar(40) NULL,
       dat_nasc             datetime NULL,
       rua                  varchar(50) NULL,
       nro_ende             integer NULL,
       compl                varchar(20) NULL,
       cep                  integer NULL,
       bairr                varchar(30) NULL,
       ddd                  integer NULL,
       cid                  varchar(40) NULL,
       tel                  integer NULL,
       rg                   varchar(15) NULL,
       cpf                  varchar(15) NULL,
       sex                  char(1) NULL,
       mail                 varchar(100) NULL,
       dat_atl              datetime NULL,
       flg_ativo            bit NULL,
       id_usu               INTEGER NULL,
       id_depto             integer NOT NULL,
       slg_est              varchar(2) NULL
)
go


ALTER TABLE Colaborador
       ADD PRIMARY KEY CLUSTERED (id_colab ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Motorfornecedor')
DROP TABLE Motorfornecedor
go

CREATE TABLE Motorfornecedor (
       id_motor             integer NOT NULL,
       id_forn              integer NOT NULL,
       dat_alt              datetime NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Motorfornecedor
       ADD PRIMARY KEY CLUSTERED (id_motor ASC, id_forn ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Pecafornecedor')
DROP TABLE Pecafornecedor
go

CREATE TABLE Pecafornecedor (
       id_peca              integer NOT NULL,
       id_forn              integer NOT NULL,
       dat_inc              datetime NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Pecafornecedor
       ADD PRIMARY KEY CLUSTERED (id_peca ASC, id_forn ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Fornecedor')
DROP TABLE Fornecedor
go

CREATE TABLE Fornecedor (
       id_forn              integer NOT NULL,
       nom                  varchar(100) NULL,
       rua                  varchar(50) NULL,
       nro_ende             integer NULL,
       compl                varchar(20) NULL,
       ddd                  integer NULL,
       bairr                varchar(50) NULL,
       tel                  integer NULL,
       cid                  varchar(50) NULL,
       mail                 varchar(100) NULL,
       cnpj                 varchar(15) NULL,
       dat_alt              datetime NULL,
       flg_ativo            bit NULL,
       slg_est              varchar(2) NULL,
       nom_pais             varchar(50) NOT NULL,
       nom_est_inter        varchar(50) NULL,
       ddi                  char(4) NULL,
       ident_inter          varchar(50) NULL,
       cod_post             varchar(20) NULL
)
go


ALTER TABLE Fornecedor
       ADD PRIMARY KEY CLUSTERED (id_forn ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Estado')
DROP TABLE Estado
go

CREATE TABLE Estado (
       slg_est              varchar(2) NOT NULL,
       nom_est              varchar(50) NULL
)
go


ALTER TABLE Estado
       ADD PRIMARY KEY CLUSTERED (slg_est ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Kitfamilia')
DROP TABLE Kitfamilia
go

CREATE TABLE Kitfamilia (
       id_kit               integer NOT NULL,
       id_fam_motor         integer NOT NULL,
       dat_alt              datetime NULL,
       qtd_kit              int NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Kitfamilia
       ADD PRIMARY KEY CLUSTERED (id_kit ASC, id_fam_motor ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Familiamotor')
DROP TABLE Familiamotor
go

CREATE TABLE Familiamotor (
       id_fam_motor         integer NOT NULL,
       id_num_motor         integer NOT NULL,
       dsc_fam_motor        varchar(500) NULL,
       flg_ativo            bit NULL,
       id_motor             integer NOT NULL,
       id_estoque           integer NULL,
       id_fam_motor_real    varchar(25) NULL,
       id_tipo_motor        integer NOT NULL
)
go


ALTER TABLE Familiamotor
       ADD PRIMARY KEY CLUSTERED (id_fam_motor ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Motor')
DROP TABLE Motor
go

CREATE TABLE Motor (
       id_motor             integer NOT NULL,
       dsc_motor            varchar(100) NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Motor
       ADD PRIMARY KEY CLUSTERED (id_motor ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Numeromotor')
DROP TABLE Numeromotor
go

CREATE TABLE Numeromotor (
       id_num_motor         integer NOT NULL,
       id_num_motor_real    varchar(25) NOT NULL,
       dsc_num_motor        varchar(500) NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Numeromotor
       ADD PRIMARY KEY CLUSTERED (id_num_motor ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Usuario')
DROP TABLE Usuario
go

CREATE TABLE Usuario (
       id_usu               INTEGER NOT NULL,
       log_usu              VARCHAR(20) NOT NULL,
       senha                VARCHAR(15) NOT NULL,
       obs_usu              varchar(100) NULL,
       flg_ativo            bit NULL,
       id_perfil            integer NOT NULL
)
go


ALTER TABLE Usuario
       ADD PRIMARY KEY CLUSTERED (id_usu ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='PecaEstoque')
DROP TABLE PecaEstoque
go

CREATE TABLE PecaEstoque (
       id_peca              integer NOT NULL,
       id_estoq             integer NOT NULL,
       flg_ativo            bit NULL,
       dat_alt              datetime NULL,
       qtd_peca             int NULL
)
go


ALTER TABLE PecaEstoque
       ADD PRIMARY KEY CLUSTERED (id_peca ASC, id_estoq ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Itempeca')
DROP TABLE Itempeca
go

CREATE TABLE Itempeca (
       id_peca              integer NOT NULL,
       dat_alt              datetime NULL,
       flg_ativo            bit NULL,
       id_item              integer NOT NULL,
       qtd_peca             int NULL
)
go


ALTER TABLE Itempeca
       ADD PRIMARY KEY CLUSTERED (id_peca ASC, id_item ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Usinagem')
DROP TABLE Usinagem
go

CREATE TABLE Usinagem (
       id_usinagem          integer NOT NULL,
       flg_status           bit NULL,
       id_peca              integer NOT NULL,
       dta_envio            datetime NULL
)
go


ALTER TABLE Usinagem
       ADD PRIMARY KEY CLUSTERED (id_usinagem ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Peca')
DROP TABLE Peca
go

CREATE TABLE Peca (
       id_peca              integer NOT NULL,
       id_peca_real         varchar(25) NULL,
       nom                  varchar(50) NULL,
       dat_alt              datetime NULL,
       peso                 decimal(10,2) NULL,
       flg_ativo            bit NULL,
       dsc_peca             varchar(500) NULL,
       qtd_min              integer NULL,
       id_tipo_peca         integer NOT NULL
)
go


ALTER TABLE Peca
       ADD PRIMARY KEY CLUSTERED (id_peca ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Tipopeca')
DROP TABLE Tipopeca
go

CREATE TABLE Tipopeca (
       id_tipo_peca         integer NOT NULL,
       dsc_tipo_peca        varchar(500) NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Tipopeca
       ADD PRIMARY KEY CLUSTERED (id_tipo_peca ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Tipomotor')
DROP TABLE Tipomotor
go

CREATE TABLE Tipomotor (
       id_tipo_motor        integer NOT NULL,
       id_tipo_motor_real   varchar(20) NOT NULL,
       dsc_tipo_motor       varchar(500) NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Tipomotor
       ADD PRIMARY KEY CLUSTERED (id_tipo_motor ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Perfilmenu')
DROP TABLE Perfilmenu
go

CREATE TABLE Perfilmenu (
       id_perfil            integer NOT NULL,
       dat_alt              datetime NULL,
       flg_ativo            bit NULL,
       id_menu              integer NOT NULL
)
go


ALTER TABLE Perfilmenu
       ADD PRIMARY KEY CLUSTERED (id_perfil ASC, id_menu ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Perfil')
DROP TABLE Perfil
go

CREATE TABLE Perfil (
       id_perfil            integer NOT NULL,
       dsc_perfil           varchar(50) NULL,
       dat_atl              datetime NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Perfil
       ADD PRIMARY KEY CLUSTERED (id_perfil ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Submenu')
DROP TABLE Submenu
go

CREATE TABLE Submenu (
       id_menu_filho        integer NOT NULL,
       id_menu_pai          integer NOT NULL,
       id_menu              integer NULL
)
go


ALTER TABLE Submenu
       ADD PRIMARY KEY CLUSTERED (id_menu_pai ASC, id_menu_filho ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Menu')
DROP TABLE Menu
go

CREATE TABLE Menu (
       id_menu              integer NOT NULL,
       dsc_menu             varchar(50) NULL,
       ende                 varchar(500) NULL,
       dat_atl              datetime NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Menu
       ADD PRIMARY KEY CLUSTERED (id_menu ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Itemkit')
DROP TABLE Itemkit
go

CREATE TABLE Itemkit (
       id_item              integer NOT NULL,
       id_kit               integer NOT NULL,
       dat_alt              datetime NULL,
       qtd_item             int NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Itemkit
       ADD PRIMARY KEY CLUSTERED (id_item ASC, id_kit ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Kitgrupopeca')
DROP TABLE Kitgrupopeca
go

CREATE TABLE Kitgrupopeca (
       id_kit               integer NOT NULL,
       id_kit_real          varchar(25) NOT NULL,
       nom                  varchar(50) NULL,
       flg_ativo            bit NULL,
       dat_alt              datetime NULL
)
go


ALTER TABLE Kitgrupopeca
       ADD PRIMARY KEY CLUSTERED (id_kit ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Item')
DROP TABLE Item
go

CREATE TABLE Item (
       id_item              integer NOT NULL,
       nom                  varchar(20) NULL,
       flg_ativo            bit NULL,
       id_item_real         varchar(25) NULL,
       dat_alt              datetime NULL
)
go


ALTER TABLE Item
       ADD PRIMARY KEY CLUSTERED (id_item ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Estoque')
DROP TABLE Estoque
go

CREATE TABLE Estoque (
       id_estoq             integer NOT NULL,
       dsc_estoq            varchar(100) NULL,
       dat_alt              datetime NULL,
       flg_ativo            bit NULL,
       id_depto             integer NOT NULL,
       flg_negativo         bit NULL
)
go


ALTER TABLE Estoque
       ADD PRIMARY KEY CLUSTERED (id_estoq ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Departamento')
DROP TABLE Departamento
go

CREATE TABLE Departamento (
       id_depto             integer NOT NULL,
       dsc_depto            varchar(500) NULL,
       dat_atl              datetime NULL,
       nom                  varchar(25) NOT NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Departamento
       ADD PRIMARY KEY CLUSTERED (id_depto ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Compra')
DROP TABLE Compra
go

CREATE TABLE Compra (
       id_compra            integer NOT NULL,
       dat                  datetime NULL,
       obs                  varchar(500) NULL,
       valor                numeric(15,2) NULL
)
go


ALTER TABLE Compra
       ADD PRIMARY KEY CLUSTERED (id_compra ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Tipoproduto')
DROP TABLE Tipoproduto
go

CREATE TABLE Tipoproduto (
       id_tipo_prod         integer IDENTITY,
       nom                  varchar(100) NULL,
       flg_ativo            bit NULL,
       dat_alt              datetime NULL
)
go


ALTER TABLE Tipoproduto
       ADD PRIMARY KEY CLUSTERED (id_tipo_prod ASC)
go


ALTER TABLE Ordemservico
       ADD FOREIGN KEY (id_compra)
                             REFERENCES Compra  (id_compra)
go


ALTER TABLE Ordemservico
       ADD FOREIGN KEY (id_venda)
                             REFERENCES Venda  (id_venda)
go


ALTER TABLE Motorestoque
       ADD FOREIGN KEY (id_motor)
                             REFERENCES Motor  (id_motor)
go


ALTER TABLE Motorestoque
       ADD FOREIGN KEY (id_estoq)
                             REFERENCES Estoque  (id_estoq)
go


ALTER TABLE Compraordemcompra
       ADD FOREIGN KEY (id_ordem_compra)
                             REFERENCES Ordemcompra  (id_ordem_compra)
go


ALTER TABLE Compraordemcompra
       ADD FOREIGN KEY (id_compra)
                             REFERENCES Compra  (id_compra)
go


ALTER TABLE Vendaproduto
       ADD FOREIGN KEY (id_prdto)
                             REFERENCES Produto  (id_prdto)
go


ALTER TABLE Vendaproduto
       ADD FOREIGN KEY (id_venda)
                             REFERENCES Venda  (id_venda)
go


ALTER TABLE Ordemdepartamento
       ADD FOREIGN KEY (id_ordem)
                             REFERENCES Produto  (id_prdto)
go


ALTER TABLE Ordemdepartamento
       ADD FOREIGN KEY (id_depto)
                             REFERENCES Departamento  (id_depto)
go


ALTER TABLE Ordemcompra
       ADD FOREIGN KEY (id_forn)
                             REFERENCES Fornecedor  (id_forn)
go


ALTER TABLE Ordemcompra
       ADD FOREIGN KEY (id_motor)
                             REFERENCES Motor  (id_motor)
go


ALTER TABLE Ordemcompra
       ADD FOREIGN KEY (id_peca)
                             REFERENCES Peca  (id_peca)
go


ALTER TABLE Produto
       ADD FOREIGN KEY (id_tipo_produto)
                             REFERENCES Tipoproduto  (id_tipo_prod)
go


ALTER TABLE Produto
       ADD FOREIGN KEY (id_kit)
                             REFERENCES Kitgrupopeca  (id_kit)
go


ALTER TABLE Produto
       ADD FOREIGN KEY (id_fam_motor)
                             REFERENCES Familiamotor  (id_fam_motor)
go


ALTER TABLE Fornecedordepto
       ADD FOREIGN KEY (id_forn)
                             REFERENCES Fornecedor  (id_forn)
go


ALTER TABLE Fornecedordepto
       ADD FOREIGN KEY (id_depto)
                             REFERENCES Departamento  (id_depto)
go


ALTER TABLE Venda
       ADD FOREIGN KEY (id_cli)
                             REFERENCES Cliente  (id_cli)
go


ALTER TABLE Cliente
       ADD FOREIGN KEY (slg_est)
                             REFERENCES Estado  (slg_est)
go


ALTER TABLE Colaborador
       ADD FOREIGN KEY (slg_est)
                             REFERENCES Estado  (slg_est)
go


ALTER TABLE Colaborador
       ADD FOREIGN KEY (id_depto)
                             REFERENCES Departamento  (id_depto)
go


ALTER TABLE Colaborador
       ADD FOREIGN KEY (id_usu)
                             REFERENCES Usuario  (id_usu)
go


ALTER TABLE Motorfornecedor
       ADD FOREIGN KEY (id_forn)
                             REFERENCES Fornecedor  (id_forn)
go


ALTER TABLE Motorfornecedor
       ADD FOREIGN KEY (id_motor)
                             REFERENCES Motor  (id_motor)
go


ALTER TABLE Pecafornecedor
       ADD FOREIGN KEY (id_forn)
                             REFERENCES Fornecedor  (id_forn)
go


ALTER TABLE Pecafornecedor
       ADD FOREIGN KEY (id_peca)
                             REFERENCES Peca  (id_peca)
go


ALTER TABLE Fornecedor
       ADD FOREIGN KEY (slg_est)
                             REFERENCES Estado  (slg_est)
go


ALTER TABLE Kitfamilia
       ADD FOREIGN KEY (id_fam_motor)
                             REFERENCES Familiamotor  (id_fam_motor)
go


ALTER TABLE Kitfamilia
       ADD FOREIGN KEY (id_kit)
                             REFERENCES Kitgrupopeca  (id_kit)
go


ALTER TABLE Familiamotor
       ADD FOREIGN KEY (id_estoque)
                             REFERENCES Estoque  (id_estoq)
go


ALTER TABLE Familiamotor
       ADD FOREIGN KEY (id_motor)
                             REFERENCES Motor  (id_motor)
go


ALTER TABLE Familiamotor
       ADD FOREIGN KEY (id_tipo_motor)
                             REFERENCES Tipomotor  (id_tipo_motor)
go


ALTER TABLE Familiamotor
       ADD FOREIGN KEY (id_num_motor)
                             REFERENCES Numeromotor  (id_num_motor)
go


ALTER TABLE Usuario
       ADD FOREIGN KEY (id_perfil)
                             REFERENCES Perfil  (id_perfil)
go


ALTER TABLE PecaEstoque
       ADD FOREIGN KEY (id_estoq)
                             REFERENCES Estoque  (id_estoq)
go


ALTER TABLE PecaEstoque
       ADD FOREIGN KEY (id_peca)
                             REFERENCES Peca  (id_peca)
go


ALTER TABLE Itempeca
       ADD FOREIGN KEY (id_item)
                             REFERENCES Item  (id_item)
go


ALTER TABLE Itempeca
       ADD FOREIGN KEY (id_peca)
                             REFERENCES Peca  (id_peca)
go


ALTER TABLE Usinagem
       ADD FOREIGN KEY (id_peca)
                             REFERENCES Peca  (id_peca)
go


ALTER TABLE Peca
       ADD FOREIGN KEY (id_tipo_peca)
                             REFERENCES Tipopeca  (id_tipo_peca)
go


ALTER TABLE Perfilmenu
       ADD FOREIGN KEY (id_menu)
                             REFERENCES Menu  (id_menu)
go


ALTER TABLE Perfilmenu
       ADD FOREIGN KEY (id_perfil)
                             REFERENCES Perfil  (id_perfil)
go


ALTER TABLE Submenu
       ADD FOREIGN KEY (id_menu)
                             REFERENCES Menu  (id_menu)
go


ALTER TABLE Itemkit
       ADD FOREIGN KEY (id_kit)
                             REFERENCES Kitgrupopeca  (id_kit)
go


ALTER TABLE Itemkit
       ADD FOREIGN KEY (id_item)
                             REFERENCES Item  (id_item)
go


ALTER TABLE Estoque
       ADD FOREIGN KEY (id_depto)
                             REFERENCES Departamento  (id_depto)
go



