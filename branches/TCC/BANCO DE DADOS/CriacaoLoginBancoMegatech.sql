
CREATE TABLE Colaborador (
       id_colab             integer NOT NULL,
       id_usu               INTEGER NULL,
       id_depto             integer NULL,
       nom_colab            varchar(40) NULL,
       dat_nasc             datetime NULL,
       nom_rua              varchar(50) NULL,
       nro_end              integer NULL,
       compl_end            varchar(20) NULL,
       cep                  varchar(10) NULL,
       bairr_end            varchar(30) NULL,
       cidade               varchar(40) NULL,
       estado               char(2) NULL,
       rg                   varchar(15) NULL,
       cpf                  varchar(15) NULL,
       sexo                 char(1) NULL,
       dat_atl              datetime NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Colaborador
       ADD PRIMARY KEY CLUSTERED (id_colab ASC)
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


CREATE TABLE Submenu (
       id_sub               integer NOT NULL,
       dsc_sub              varchar(50) NULL,
       end_sub              varchar(500) NULL,
       dat_atl              datetime NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Submenu
       ADD PRIMARY KEY CLUSTERED (id_sub ASC)
go


CREATE TABLE Usuario (
       id_usu               INTEGER NOT NULL,
       login                VARCHAR(20) NOT NULL,
       dsc_usu              VARCHAR(50) NULL,
       senha                VARCHAR(15) NOT NULL,
       tipo                 CHAR(1) NULL,
       dsc_tipo             VARCHAR(30) NULL,
       flg_admin            bit NOT NULL,
       flg_ativo            bit NULL
)
go


ALTER TABLE Usuario
       ADD PRIMARY KEY CLUSTERED (id_usu ASC)
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


ALTER TABLE Colaborador
       ADD FOREIGN KEY (id_depto)
                             REFERENCES Departamento  (id_depto)
go


ALTER TABLE Colaborador
       ADD FOREIGN KEY (id_usu)
                             REFERENCES Usuario  (id_usu)
go


ALTER TABLE Menusubmenu
       ADD FOREIGN KEY (id_sub)
                             REFERENCES Submenu  (id_sub)
go


ALTER TABLE Menusubmenu
       ADD FOREIGN KEY (id_menu)
                             REFERENCES Menu  (id_menu)
go


ALTER TABLE Perfilmenu
       ADD FOREIGN KEY (id_menu)
                             REFERENCES Menu  (id_menu)
go


ALTER TABLE Perfilmenu
       ADD FOREIGN KEY (id_perfil)
                             REFERENCES Perfil  (id_perfil)
go


ALTER TABLE Usuarioperfil
       ADD FOREIGN KEY (id_perfil)
                             REFERENCES Perfil  (id_perfil)
go


ALTER TABLE Usuarioperfil
       ADD FOREIGN KEY (id_usu)
                             REFERENCES Usuario  (id_usu)
go



