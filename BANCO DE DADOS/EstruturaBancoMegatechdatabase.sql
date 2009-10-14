CREATE DATABASE Megatechdatabase
go

DROP TABLE Compra
go

CREATE TABLE Compra (
       id_depto             integer NOT NULL,
       id_compra            integer NOT NULL,
       dat_compra           datetime NULL,
       obs_compra           varchar(20) NULL,
       id_fornecedor        integer NOT NULL,
       id_motor_compra      integer NULL,
       qtd_comp             integer NULL,
       val_comp             numeric(15,2) NULL,
       nro_nota_fiscal      integer NULL,
       id_tipo_produto      integer NOT NULL,
       id_peca              varchar(20) NULL
)
go


ALTER TABLE Compra
       ADD PRIMARY KEY CLUSTERED (id_compra ASC)
go


DROP TABLE Comprapeca
go

CREATE TABLE Comprapeca (
       id_peca              varchar(20) NOT NULL,
       ultimo_preco         integer NULL
)
go


ALTER TABLE Comprapeca
       ADD PRIMARY KEY CLUSTERED (id_peca ASC)
go


DROP TABLE Pedidovenda
go

CREATE TABLE Pedidovenda (
       id_pedido            integer NOT NULL,
       id_venda             integer NOT NULL,
       id_depto             integer NULL,
       dsc_pedido           varchar(500) NULL,
       dat_alt              datetime NULL
)
go


ALTER TABLE Pedidovenda
       ADD PRIMARY KEY CLUSTERED (id_venda ASC)
go


DROP TABLE Venda
go

CREATE TABLE Venda (
       id_venda             integer NOT NULL,
       id_motor             integer NULL,
       id_cli               integer NOT NULL,
       dat_venda            datetime NULL,
       qtd_venda            integer NULL,
       val_venda            numeric(15,2) NULL,
       nota_fisc            varchar(20) NULL,
       dat_saida            datetime NULL,
       id_ordem_kit         integer NOT NULL,
       id_tipo_produto      integer NOT NULL,
       id_grupo             integer NULL
)
go


ALTER TABLE Venda
       ADD PRIMARY KEY CLUSTERED (id_venda ASC)
go


DROP TABLE Ordemproducao
go

CREATE TABLE Ordemproducao (
       id_ordem_kit         integer NOT NULL,
       dsc_ordem            varchar(500) NULL,
       id_depto             integer NOT NULL,
       id_motor             integer NULL,
       id_grupo             integer NULL,
       id_tipo_produto      integer NOT NULL
)
go


ALTER TABLE Ordemproducao
       ADD PRIMARY KEY CLUSTERED (id_ordem_kit ASC)
go


DROP TABLE Fornecedordepto
go

CREATE TABLE Fornecedordepto (
       id_depto             integer NOT NULL,
       id_fornecedor        integer NOT NULL,
       dat_alt              datetime NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Fornecedordepto
       ADD PRIMARY KEY CLUSTERED (id_depto ASC, id_fornecedor ASC)
go


DROP TABLE Cliente
go

CREATE TABLE Cliente (
       id_cli               integer NOT NULL,
       nom_cli              varchar(60) NULL,
       tel_cli              varchar(20) NULL,
       nom_rua              varchar(100) NULL,
       num_end              integer NULL,
       compl_end            varchar(20) NULL,
       cep                  integer NULL,
       bairr_end            varchar(20) NULL,
       cidade               varchar(50) NULL,
       id_rg                integer NULL,
       id_cnpj              integer NULL,
       dat_atl              datetime NULL,
       flg_ativo            bit NULL,
       slg_estado           varchar(2) NOT NULL,
       email_cliente        varchar(100) NULL,
       ddd_cliente          integer NULL
)
go


ALTER TABLE Cliente
       ADD PRIMARY KEY CLUSTERED (id_cli ASC)
go


DROP TABLE Colaborador
go

CREATE TABLE Colaborador (
       id_colab             integer NOT NULL,
       nom_colab            varchar(40) NULL,
       dat_nasc             datetime NULL,
       nom_rua              varchar(50) NULL,
       nro_end              integer NULL,
       compl_end            varchar(20) NULL,
       cep                  varchar(10) NULL,
       bairr_end            varchar(30) NULL,
       ddd_colab            integer NULL,
       cidade               varchar(40) NULL,
       tel_colab            integer NULL,
       rg                   varchar(15) NULL,
       cpf                  varchar(15) NULL,
       sexo                 char(1) NULL,
       email_colab          varchar(100) NULL,
       dat_atl              datetime NULL,
       flg_ativo            bit NULL,
       id_usu               INTEGER NULL,
       id_depto             integer NOT NULL,
       slg_estado           varchar(2) NULL
)
go


ALTER TABLE Colaborador
       ADD PRIMARY KEY CLUSTERED (id_colab ASC)
go


DROP TABLE Pecafornecedor
go

CREATE TABLE Pecafornecedor (
       id_peca              varchar(20) NOT NULL,
       id_fornecedor        integer NOT NULL,
       dat_inc              datetime NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Pecafornecedor
       ADD PRIMARY KEY CLUSTERED (id_peca ASC, id_fornecedor ASC)
go


DROP TABLE Fornecedor
go

CREATE TABLE Fornecedor (
       id_fornecedor        integer NOT NULL,
       nom_fornecedor       varchar(100) NULL,
       nom_rua_fornecedor   varchar(50) NULL,
       nro_end_fornecedor   integer NULL,
       compl_end_fornecedor varchar(20) NULL,
       cep_fornecedor       integer NULL,
       DDD                  integer NULL,
       bairr_end_fornecedor varchar(50) NULL,
       tel_fornecedor       integer NULL,
       cidade_fornecedor    varchar(50) NULL,
       Email                varchar(100) NULL,
       id_cnpj_fornecedor   integer NULL,
       dat_alt              datetime NULL,
       flg_ativo            bit NULL,
       slg_estado           varchar(2) NULL
)
go


ALTER TABLE Fornecedor
       ADD PRIMARY KEY CLUSTERED (id_fornecedor ASC)
go


DROP TABLE Estado
go

CREATE TABLE Estado (
       slg_estado           varchar(2) NOT NULL,
       nom_estado           varchar(50) NULL
)
go


ALTER TABLE Estado
       ADD PRIMARY KEY CLUSTERED (slg_estado ASC)
go


DROP TABLE Familiamotor
go

CREATE TABLE Familiamotor (
       id_motor             integer NOT NULL,
       id_num_motor         integer NOT NULL,
       id_grupo             integer NOT NULL,
       id_tipo_motor        varchar(20) NOT NULL,
       dsc_motor            varchar(500) NULL,
       flg_ativo            bit NULL,
       id_motor_compra      integer NOT NULL,
       id_estoque           integer NOT NULL
)
go


ALTER TABLE Familiamotor
       ADD PRIMARY KEY CLUSTERED (id_motor ASC)
go


DROP TABLE Motor
go

CREATE TABLE Motor (
       id_motor_compra      integer NOT NULL,
       dsc_motor_compra     varchar(100) NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Motor
       ADD PRIMARY KEY CLUSTERED (id_motor_compra ASC)
go


DROP TABLE Numeromotor
go

CREATE TABLE Numeromotor (
       id_num_motor         integer NOT NULL,
       dsc_num_motor        varchar(50) NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Numeromotor
       ADD PRIMARY KEY CLUSTERED (id_num_motor ASC)
go


DROP TABLE Usuarioperfil
go

CREATE TABLE Usuarioperfil (
       id_usu               INTEGER NOT NULL,
       flg_ativo            bit NULL,
       id_perfil            integer NOT NULL,
       dat_trans            datetime NULL
)
go


ALTER TABLE Usuarioperfil
       ADD PRIMARY KEY CLUSTERED (id_usu ASC, id_perfil ASC)
go


DROP TABLE Usuario
go

CREATE TABLE Usuario (
       id_usu               INTEGER NOT NULL,
       login                VARCHAR(20) NOT NULL,
       senha                VARCHAR(15) NOT NULL,
       obs_usu              varchar(100) NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Usuario
       ADD PRIMARY KEY CLUSTERED (id_usu ASC)
go


DROP TABLE Usinagem
go

CREATE TABLE Usinagem (
       id_usinagem          integer NOT NULL,
       flg_status           bit NULL,
       id_peca              varchar(20) NOT NULL,
       dta_envio            datetime NULL
)
go


ALTER TABLE Usinagem
       ADD PRIMARY KEY CLUSTERED (id_usinagem ASC)
go


DROP TABLE Kitgrupopeca
go

CREATE TABLE Kitgrupopeca (
       id_grupo             integer NOT NULL,
       nom_grupo            varchar(50) NULL,
       flg_ativo            bit NULL,
       id_item_peca         integer NOT NULL,
       id_peca              varchar(20) NOT NULL
)
go


ALTER TABLE Kitgrupopeca
       ADD PRIMARY KEY CLUSTERED (id_grupo ASC)
go


DROP TABLE Itempeca
go

CREATE TABLE Itempeca (
       id_item_peca         integer NOT NULL,
       nom_item_peca        varchar(20) NULL,
       flg_ativo            bit NULL,
       id_peca              varchar(20) NOT NULL
)
go


ALTER TABLE Itempeca
       ADD PRIMARY KEY CLUSTERED (id_item_peca ASC, id_peca ASC)
go


DROP TABLE Peca
go

CREATE TABLE Peca (
       id_peca              varchar(20) NOT NULL,
       nom_peca             varchar(50) NULL,
       dat_alt              datetime NULL,
       peso                 decimal(10,2) NULL,
       flg_ativo            bit NULL,
       dsc_peca             varchar(100) NULL,
       id_estoque           integer NOT NULL,
       qtd_minima           integer NULL,
       id_tipo_peca         integer NOT NULL
)
go


ALTER TABLE Peca
       ADD PRIMARY KEY CLUSTERED (id_peca ASC)
go


DROP TABLE Tipodepeca
go

CREATE TABLE Tipodepeca (
       id_tipo_peca         integer NOT NULL,
       dsc_tipo_peca        varchar(500) NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Tipodepeca
       ADD PRIMARY KEY CLUSTERED (id_tipo_peca ASC)
go


DROP TABLE Tipomotor
go

CREATE TABLE Tipomotor (
       id_tipo_motor        varchar(20) NOT NULL,
       nom_tipo_motor       varchar(50) NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Tipomotor
       ADD PRIMARY KEY CLUSTERED (id_tipo_motor ASC)
go


DROP TABLE Perfilmenu
go

CREATE TABLE Perfilmenu (
       id_perfil            integer NOT NULL,
       dat_trans            datetime NULL,
       flg_ativo            bit NULL,
       id_menu              integer NOT NULL
)
go


ALTER TABLE Perfilmenu
       ADD PRIMARY KEY CLUSTERED (id_perfil ASC, id_menu ASC)
go


DROP TABLE Perfil
go

CREATE TABLE Perfil (
       id_perfil            integer NOT NULL,
       dsc_perfil           varchar(30) NULL,
       dat_atl              datetime NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Perfil
       ADD PRIMARY KEY CLUSTERED (id_perfil ASC)
go


DROP TABLE Menusubmenu
go

CREATE TABLE Menusubmenu (
       id_menu              integer NOT NULL,
       id_sub               integer NOT NULL,
       dat_trans            datetime NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Menusubmenu
       ADD PRIMARY KEY CLUSTERED (id_menu ASC, id_sub ASC)
go


DROP TABLE Menu
go

CREATE TABLE Menu (
       id_menu              integer NOT NULL,
       dsc_menu             varchar(50) NULL,
       end_menu             varchar(500) NULL,
       dat_atl              datetime NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Menu
       ADD PRIMARY KEY CLUSTERED (id_menu ASC)
go


DROP TABLE Estoque
go

CREATE TABLE Estoque (
       id_estoque           integer NOT NULL,
       nom_estoque          varchar(100) NULL,
       dat_alt              datetime NULL,
       flg_ativo            bit NULL,
       id_depto             integer NOT NULL
)
go


ALTER TABLE Estoque
       ADD PRIMARY KEY CLUSTERED (id_estoque ASC)
go


DROP TABLE Departamento
go

CREATE TABLE Departamento (
       id_depto             integer NOT NULL,
       dsc_depto            varchar(30) NULL,
       dat_atl              datetime NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Departamento
       ADD PRIMARY KEY CLUSTERED (id_depto ASC)
go


DROP TABLE Submenu
go

CREATE TABLE Submenu (
       id_sub               integer NOT NULL,
       dsc_sub              varchar(50) NULL,
       end_sub              varchar(500) NULL,
       dat_atl              datetime NULL,
       flg_ativo            bit NULL,
       id_sub_pai           integer NULL,
       id_sub_filho         char(18) NULL
)
go


ALTER TABLE Submenu
       ADD PRIMARY KEY CLUSTERED (id_sub ASC)
go


DROP TABLE Tipoproduto
go

CREATE TABLE Tipoproduto (
       id_tipo_produto      integer NOT NULL,
       nom_tipo_produto     varchar(100) NULL,
       flg_ativo            bit NULL,
       dat_alt              datetime NULL
)
go


ALTER TABLE Tipoproduto
       ADD PRIMARY KEY CLUSTERED (id_tipo_produto ASC)
go


ALTER TABLE Compra
       ADD FOREIGN KEY (id_peca)
                             REFERENCES Comprapeca  (id_peca)
go


ALTER TABLE Compra
       ADD FOREIGN KEY (id_tipo_produto)
                             REFERENCES Tipoproduto  (id_tipo_produto)
go


ALTER TABLE Compra
       ADD FOREIGN KEY (id_motor_compra)
                             REFERENCES Motor  (id_motor_compra)
go


ALTER TABLE Compra
       ADD FOREIGN KEY (id_fornecedor)
                             REFERENCES Fornecedor  (id_fornecedor)
go


ALTER TABLE Compra
       ADD FOREIGN KEY (id_depto)
                             REFERENCES Departamento  (id_depto)
go


ALTER TABLE Comprapeca
       ADD FOREIGN KEY (id_peca)
                             REFERENCES Peca  (id_peca)
go


ALTER TABLE Pedidovenda
       ADD FOREIGN KEY (id_depto)
                             REFERENCES Departamento  (id_depto)
go


ALTER TABLE Pedidovenda
       ADD FOREIGN KEY (id_venda)
                             REFERENCES Venda  (id_venda)
go


ALTER TABLE Venda
       ADD FOREIGN KEY (id_grupo)
                             REFERENCES Kitgrupopeca  (id_grupo)
go


ALTER TABLE Venda
       ADD FOREIGN KEY (id_tipo_produto)
                             REFERENCES Tipoproduto  (id_tipo_produto)
go


ALTER TABLE Venda
       ADD FOREIGN KEY (id_ordem_kit)
                             REFERENCES Ordemproducao  (id_ordem_kit)
go


ALTER TABLE Venda
       ADD FOREIGN KEY (id_cli)
                             REFERENCES Cliente  (id_cli)
go


ALTER TABLE Venda
       ADD FOREIGN KEY (id_motor)
                             REFERENCES Familiamotor  (id_motor)
go


ALTER TABLE Ordemproducao
       ADD FOREIGN KEY (id_tipo_produto)
                             REFERENCES Tipoproduto  (id_tipo_produto)
go


ALTER TABLE Ordemproducao
       ADD FOREIGN KEY (id_grupo)
                             REFERENCES Kitgrupopeca  (id_grupo)
go


ALTER TABLE Ordemproducao
       ADD FOREIGN KEY (id_motor)
                             REFERENCES Familiamotor  (id_motor)
go


ALTER TABLE Ordemproducao
       ADD FOREIGN KEY (id_depto)
                             REFERENCES Departamento  (id_depto)
go


ALTER TABLE Fornecedordepto
       ADD FOREIGN KEY (id_fornecedor)
                             REFERENCES Fornecedor  (id_fornecedor)
go


ALTER TABLE Fornecedordepto
       ADD FOREIGN KEY (id_depto)
                             REFERENCES Departamento  (id_depto)
go


ALTER TABLE Cliente
       ADD FOREIGN KEY (slg_estado)
                             REFERENCES Estado  (slg_estado)
go


ALTER TABLE Colaborador
       ADD FOREIGN KEY (slg_estado)
                             REFERENCES Estado  (slg_estado)
go


ALTER TABLE Colaborador
       ADD FOREIGN KEY (id_depto)
                             REFERENCES Departamento  (id_depto)
go


ALTER TABLE Colaborador
       ADD FOREIGN KEY (id_usu)
                             REFERENCES Usuario  (id_usu)
go


ALTER TABLE Pecafornecedor
       ADD FOREIGN KEY (id_fornecedor)
                             REFERENCES Fornecedor  (id_fornecedor)
go


ALTER TABLE Pecafornecedor
       ADD FOREIGN KEY (id_peca)
                             REFERENCES Peca  (id_peca)
go


ALTER TABLE Fornecedor
       ADD FOREIGN KEY (slg_estado)
                             REFERENCES Estado  (slg_estado)
go


ALTER TABLE Familiamotor
       ADD FOREIGN KEY (id_estoque)
                             REFERENCES Estoque  (id_estoque)
go


ALTER TABLE Familiamotor
       ADD FOREIGN KEY (id_motor_compra)
                             REFERENCES Motor  (id_motor_compra)
go


ALTER TABLE Familiamotor
       ADD FOREIGN KEY (id_tipo_motor)
                             REFERENCES Tipomotor  (id_tipo_motor)
go


ALTER TABLE Familiamotor
       ADD FOREIGN KEY (id_grupo)
                             REFERENCES Kitgrupopeca  (id_grupo)
go


ALTER TABLE Familiamotor
       ADD FOREIGN KEY (id_num_motor)
                             REFERENCES Numeromotor  (id_num_motor)
go


ALTER TABLE Usuarioperfil
       ADD FOREIGN KEY (id_perfil)
                             REFERENCES Perfil  (id_perfil)
go


ALTER TABLE Usuarioperfil
       ADD FOREIGN KEY (id_usu)
                             REFERENCES Usuario  (id_usu)
go


ALTER TABLE Usinagem
       ADD FOREIGN KEY (id_peca)
                             REFERENCES Peca  (id_peca)
go


ALTER TABLE Kitgrupopeca
       ADD FOREIGN KEY (id_item_peca, id_peca)
                             REFERENCES Itempeca  (id_item_peca, 
              id_peca)
go


ALTER TABLE Itempeca
       ADD FOREIGN KEY (id_peca)
                             REFERENCES Peca  (id_peca)
go


ALTER TABLE Peca
       ADD FOREIGN KEY (id_tipo_peca)
                             REFERENCES Tipodepeca  (id_tipo_peca)
go


ALTER TABLE Peca
       ADD FOREIGN KEY (id_estoque)
                             REFERENCES Estoque  (id_estoque)
go


ALTER TABLE Perfilmenu
       ADD FOREIGN KEY (id_menu)
                             REFERENCES Menu  (id_menu)
go


ALTER TABLE Perfilmenu
       ADD FOREIGN KEY (id_perfil)
                             REFERENCES Perfil  (id_perfil)
go


ALTER TABLE Menusubmenu
       ADD FOREIGN KEY (id_sub)
                             REFERENCES Submenu  (id_sub)
go


ALTER TABLE Menusubmenu
       ADD FOREIGN KEY (id_menu)
                             REFERENCES Menu  (id_menu)
go


ALTER TABLE Estoque
       ADD FOREIGN KEY (id_depto)
                             REFERENCES Departamento  (id_depto)
go



