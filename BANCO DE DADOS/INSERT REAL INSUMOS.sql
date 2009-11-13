USE Megatechdatabase
go

--fornecedor
INSERT INTO Fornecedor( id_forn, nom, rua, nro_ende, compl, cep, ddd, bairr, tel, cid, mail, cnpj, dat_alt, flg_ativo,slg_est)VALUES (1,'Peças & Equips', 'Dom Bosco', 357,'Apartamento', 11070098, 33, 'Vila Nova', 56985880, 'Manaus', 'peçasequips@mail.com','123468579', GETDATE(), 1, 'am');
INSERT INTO Fornecedor( id_forn, nom, rua, nro_ende, compl, cep, ddd, bairr, tel, cid, mail, cnpj, dat_alt, flg_ativo,slg_est)VALUES (2,'Mercedes', 'Vinicius de Morais', 1085,'casa', 11070000, 25, 'Rio de Janeiro', 56556680, 'Rio de aneiro', 'bwm@mail.com','123468579', GETDATE(), 1, 'rj');

--Numero Motor
INSERT INTO Numeromotor(id_num_motor ,id_num_motor_real ,dsc_num_motor ,flg_ativo) VALUES (1,'366','Default' , 1);
INSERT INTO Numeromotor(id_num_motor ,id_num_motor_real ,dsc_num_motor ,flg_ativo) VALUES (2,'447','Moto Bomba' ,1);

--TipoMotor
INSERT INTO Tipomotor(id_tipo_motor ,id_tipo_motor_real ,dsc_tipo_motor ,flg_ativo) VALUES (1,'LA', 'Turbo Aspirado', 1);
INSERT INTO Tipomotor(id_tipo_motor ,id_tipo_motor_real ,dsc_tipo_motor ,flg_ativo) VALUES (2,'A', 'Aspirado', 1);

--kitGrupoPeca
INSERT INTO Kitgrupopeca(id_kit, id_kit_real,nom, flg_ativo,dat_alt) VALUES (1 ,'014', 'KIT 366 LA',1,GETDATE());
INSERT INTO Kitgrupopeca(id_kit, id_kit_real,nom, flg_ativo,dat_alt) VALUES (2 ,'015', 'KIT 447 A',1,GETDATE());

--Peças
INSERT INTO Peca( id_peca,id_peca_real ,nom ,dat_alt ,peso ,flg_ativo ,dsc_peca,qtd_min,id_tipo_peca) VALUES (1 ,'1.0.0', 'Solenóide', GETDATE() , 1.0, 1, 'SOLENÓIDE DO MOTOR 366 LA',5, 1 );
INSERT INTO Peca( id_peca,id_peca_real ,nom ,dat_alt ,peso ,flg_ativo ,dsc_peca,qtd_min,id_tipo_peca) VALUES (2 ,'1.1.0', 'Porca', GETDATE() , 0.1, 1, 'PORCA DO MOTOR 366 LA',10, 2 );
INSERT INTO Peca( id_peca,id_peca_real ,nom ,dat_alt ,peso ,flg_ativo ,dsc_peca,qtd_min,id_tipo_peca) VALUES (3 ,'1.0.0', 'Filtro de Ar', GETDATE() , 0.5, 1, 'FILTRO DE AR  DO MOTOR 447 A',8, 3 );
INSERT INTO Peca( id_peca,id_peca_real ,nom ,dat_alt ,peso ,flg_ativo ,dsc_peca,qtd_min,id_tipo_peca) VALUES (4 ,'1.0.0', 'Solenóide de Parada', GETDATE() , 1.0, 1, 'SOLENÓIDE DE PARADA DO MOTOR 447 A',6, 4 );

--DEPARTAMENTO
INSERT INTO Departamento (id_depto,dsc_depto ,dat_atl ,flg_ativo) 	VALUES (1 ,'Almoxarifado',GETDATE() , 1);
INSERT INTO Departamento (id_depto,dsc_depto ,dat_atl ,flg_ativo) 	VALUES (2 ,'Usinagem',GETDATE() , 1);
INSERT INTO Departamento (id_depto,dsc_depto ,dat_atl ,flg_ativo) 	VALUES (3 ,'Produção',GETDATE() , 1);

--Estoque
INSERT INTO Estoque (id_estoq, dsc_estoq,dat_alt , flg_ativo, id_depto, flg_negativo) VALUES (1 ,'Estoque do almoxarifado', GETDATE() , 1 , 1 ,0);
INSERT INTO Estoque (id_estoq, dsc_estoq,dat_alt , flg_ativo, id_depto, flg_negativo) VALUES (2 ,'Estoque da Usinagem', GETDATE() , 1 , 2 ,0);
INSERT INTO Estoque (id_estoq, dsc_estoq,dat_alt , flg_ativo, id_depto, flg_negativo) VALUES (3 ,'Estoque da Produção', GETDATE() , 1 , 3 ,0);
INSERT INTO Estoque (id_estoq, dsc_estoq,dat_alt , flg_ativo, id_depto, flg_negativo) VALUES (4 ,'Estoque do Peças Defeituosas', GETDATE() , 1 , 2 ,0);


--item 
--???

--colaborador
-- fazer
