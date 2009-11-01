
IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Comprapeca')
DROP TABLE Comprapeca
go

CREATE TABLE Comprapeca (
       id_peca              integer NOT NULL,
       ultim_preco          numeric(15,2) NULL,
       id_compra            integer NOT NULL
)
go


ALTER TABLE Comprapeca
       ADD PRIMARY KEY CLUSTERED (id_peca ASC, id_compra ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Pedidovenda')
DROP TABLE Pedidovenda
go

CREATE TABLE Pedidovenda (
       id_pedido            integer IDENTITY,
       id_venda             integer NOT NULL,
       id_depto             integer NOT NULL,
       dsc_venda            varchar(500) NULL,
       dat_alt              datetime NULL,
       id_fam_motor         integer NOT NULL,
       id_kit               integer NOT NULL,
       id_tipo_prod         integer NOT NULL
)
go


ALTER TABLE Pedidovenda
       ADD PRIMARY KEY CLUSTERED (id_pedido ASC, id_venda ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Venda')
DROP TABLE Venda
go

CREATE TABLE Venda (
       id_venda             integer IDENTITY,
       id_cli               integer NOT NULL,
       dat_venda            datetime NULL,
       qtd                  integer NULL,
       valor                numeric(15,2) NULL,
       nota_fisc            varchar(20) NULL,
       dat_saida            datetime NULL,
       id_ordem             integer NOT NULL,
       id_tipo_prod         integer NOT NULL
)
go


ALTER TABLE Venda
       ADD PRIMARY KEY CLUSTERED (id_venda ASC, id_tipo_prod ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Ordemproducao')
DROP TABLE Ordemproducao
go

CREATE TABLE Ordemproducao (
       id_ordem             integer IDENTITY,
       dsc_ordem            varchar(500) NULL,
       id_depto             integer NOT NULL,
       id_fam_motor         integer NULL,
       id_kit               integer NULL,
       id_tipo_produto      integer NOT NULL
)
go


ALTER TABLE Ordemproducao
       ADD PRIMARY KEY CLUSTERED (id_ordem ASC)
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


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Cliente')
DROP TABLE Cliente
go

CREATE TABLE Cliente (
       id_cli               integer IDENTITY,
       nom                  varchar(60) NULL,
       tel                  integer NULL,
       rua                  varchar(100) NULL,
       nro_ende             integer NULL,
       compl                varchar(20) NULL,
       cep                  integer NULL,
       bairr                varchar(20) NULL,
       cid                  varchar(50) NULL,
       cpf                  varchar(15) NULL,
       dat_atl              datetime NULL,
       flg_ativo            bit NULL,
       slg_est              varchar(2) NOT NULL,
       mail                 varchar(100) NULL,
       ddd                  integer NULL,
       cnpj                 numeric(15) NULL
)
go


ALTER TABLE Cliente
       ADD PRIMARY KEY CLUSTERED (id_cli ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Colaborador')
DROP TABLE Colaborador
go

CREATE TABLE Colaborador (
       id_colab             integer IDENTITY,
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


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Compra')
DROP TABLE Compra
go

CREATE TABLE Compra (
       id_depto             integer NOT NULL,
       id_compra            integer IDENTITY,
       dat                  datetime NULL,
       obs                  varchar(500) NULL,
       id_forn              integer NOT NULL,
       id_motor             integer NULL,
       qtd                  integer NULL,
       valor                numeric(15,2) NULL,
       nota_fisc            varchar(20) NULL,
       id_tipo_produto      integer NOT NULL
)
go


ALTER TABLE Compra
       ADD PRIMARY KEY CLUSTERED (id_compra ASC)
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
       id_forn              integer IDENTITY,
       nom                  varchar(100) NULL,
       rua                  varchar(50) NULL,
       nro_ende             integer NULL,
       compl                varchar(20) NULL,
       cep                  integer NULL,
       ddd                  integer NULL,
       bairr                varchar(50) NULL,
       tel                  integer NULL,
       cid                  varchar(50) NULL,
       mail                 varchar(100) NULL,
       cnpj                 varchar(15) NULL,
       dat_alt              datetime NULL,
       flg_ativo            bit NULL,
       slg_est              varchar(2) NULL
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
       id_fam_motor         integer NOT NULL
)
go


ALTER TABLE Kitfamilia
       ADD PRIMARY KEY CLUSTERED (id_kit ASC, id_fam_motor ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Familiamotor')
DROP TABLE Familiamotor
go

CREATE TABLE Familiamotor (
       id_fam_motor         integer IDENTITY,
       id_num_motor         integer NOT NULL,
       id_kit               integer NOT NULL,
       dsc_fam_motor        varchar(500) NULL,
       flg_ativo            bit NULL,
       id_motor             integer NOT NULL,
       id_estoque           integer NOT NULL,
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
       id_motor             integer IDENTITY,
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
       id_num_motor         integer IDENTITY,
       id_num_motor_real    varchar(20) NOT NULL,
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
       id_usu               INTEGER IDENTITY,
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


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Itempeca')
DROP TABLE Itempeca
go

CREATE TABLE Itempeca (
       id_item_peca         integer NOT NULL,
       id_peca              integer NOT NULL,
       dat_alt              datetime NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Itempeca
       ADD PRIMARY KEY CLUSTERED (id_item_peca ASC, id_peca ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Usinagem')
DROP TABLE Usinagem
go

CREATE TABLE Usinagem (
       id_usinagem          integer IDENTITY,
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
       id_peca              integer IDENTITY,
       id_peca_real         varchar(50) NULL,
       nom                  varchar(50) NULL,
       dat_alt              datetime NULL,
       peso                 decimal(10,2) NULL,
       flg_ativo            bit NULL,
       dsc_peca             varchar(500) NULL,
       id_estoque           integer NOT NULL,
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
       id_tipo_peca         integer IDENTITY,
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
       id_tipo_motor        integer IDENTITY,
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
       id_perfil            integer IDENTITY,
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
       id_menu              integer IDENTITY,
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
       id_kit               integer NOT NULL
)
go


ALTER TABLE Itemkit
       ADD PRIMARY KEY CLUSTERED (id_item ASC, id_kit ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Kitgrupopeca')
DROP TABLE Kitgrupopeca
go

CREATE TABLE Kitgrupopeca (
       id_kit               integer IDENTITY,
       id_kit_real          varchar(10) NOT NULL,
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
       id_item              integer IDENTITY,
       nom                  varchar(20) NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Item
       ADD PRIMARY KEY CLUSTERED (id_item ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Estoque')
DROP TABLE Estoque
go

CREATE TABLE Estoque (
       id_estoq             integer IDENTITY,
       dsc_estoq            varchar(100) NULL,
       dat_alt              datetime NULL,
       flg_ativo            bit NULL,
       id_depto             integer NOT NULL
)
go


ALTER TABLE Estoque
       ADD PRIMARY KEY CLUSTERED (id_estoq ASC)
go


IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='Departamento')
DROP TABLE Departamento
go

CREATE TABLE Departamento (
       id_depto             integer IDENTITY,
       dsc_depto            varchar(30) NULL,
       dat_atl              datetime NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Departamento
       ADD PRIMARY KEY CLUSTERED (id_depto ASC)
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


ALTER TABLE Comprapeca
       ADD FOREIGN KEY (id_compra)
                             REFERENCES Compra  (id_compra)
go


ALTER TABLE Comprapeca
       ADD FOREIGN KEY (id_peca)
                             REFERENCES Peca  (id_peca)
go


ALTER TABLE Pedidovenda
       ADD FOREIGN KEY (id_kit)
                             REFERENCES Kitgrupopeca  (id_kit)
go


ALTER TABLE Pedidovenda
       ADD FOREIGN KEY (id_fam_motor)
                             REFERENCES Familiamotor  (id_fam_motor)
go


ALTER TABLE Pedidovenda
       ADD FOREIGN KEY (id_depto)
                             REFERENCES Departamento  (id_depto)
go


ALTER TABLE Pedidovenda
       ADD FOREIGN KEY (id_venda, id_tipo_prod)
                             REFERENCES Venda  (id_venda, 
              id_tipo_prod)
go


ALTER TABLE Venda
       ADD FOREIGN KEY (id_tipo_prod)
                             REFERENCES Tipoproduto  (id_tipo_prod)
go


ALTER TABLE Venda
       ADD FOREIGN KEY (id_ordem)
                             REFERENCES Ordemproducao  (id_ordem)
go


ALTER TABLE Venda
       ADD FOREIGN KEY (id_cli)
                             REFERENCES Cliente  (id_cli)
go


ALTER TABLE Ordemproducao
       ADD FOREIGN KEY (id_tipo_produto)
                             REFERENCES Tipoproduto  (id_tipo_prod)
go


ALTER TABLE Ordemproducao
       ADD FOREIGN KEY (id_kit)
                             REFERENCES Kitgrupopeca  (id_kit)
go


ALTER TABLE Ordemproducao
       ADD FOREIGN KEY (id_fam_motor)
                             REFERENCES Familiamotor  (id_fam_motor)
go


ALTER TABLE Ordemproducao
       ADD FOREIGN KEY (id_depto)
                             REFERENCES Departamento  (id_depto)
go


ALTER TABLE Fornecedordepto
       ADD FOREIGN KEY (id_forn)
                             REFERENCES Fornecedor  (id_forn)
go


ALTER TABLE Fornecedordepto
       ADD FOREIGN KEY (id_depto)
                             REFERENCES Departamento  (id_depto)
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


ALTER TABLE Compra
       ADD FOREIGN KEY (id_tipo_produto)
                             REFERENCES Tipoproduto  (id_tipo_prod)
go


ALTER TABLE Compra
       ADD FOREIGN KEY (id_motor)
                             REFERENCES Motor  (id_motor)
go


ALTER TABLE Compra
       ADD FOREIGN KEY (id_forn)
                             REFERENCES Fornecedor  (id_forn)
go


ALTER TABLE Compra
       ADD FOREIGN KEY (id_depto)
                             REFERENCES Departamento  (id_depto)
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
       ADD FOREIGN KEY (id_kit)
                             REFERENCES Kitgrupopeca  (id_kit)
go


ALTER TABLE Familiamotor
       ADD FOREIGN KEY (id_num_motor)
                             REFERENCES Numeromotor  (id_num_motor)
go


ALTER TABLE Usuario
       ADD FOREIGN KEY (id_perfil)
                             REFERENCES Perfil  (id_perfil)
go


ALTER TABLE Itempeca
       ADD FOREIGN KEY (id_peca)
                             REFERENCES Peca  (id_peca)
go


ALTER TABLE Itempeca
       ADD FOREIGN KEY (id_item_peca)
                             REFERENCES Item  (id_item)
go


ALTER TABLE Usinagem
       ADD FOREIGN KEY (id_peca)
                             REFERENCES Peca  (id_peca)
go


ALTER TABLE Peca
       ADD FOREIGN KEY (id_tipo_peca)
                             REFERENCES Tipopeca  (id_tipo_peca)
go


ALTER TABLE Peca
       ADD FOREIGN KEY (id_estoque)
                             REFERENCES Estoque  (id_estoq)
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



