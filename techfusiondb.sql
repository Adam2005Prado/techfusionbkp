create database DataBase_TechFusion;
use DataBase_TechFusion;

create table produto(
	Cod_prod int primary key auto_increment,
    Nome_prod varchar(70),
    preco_prod float(10,2)
);

create table produto_soft(
Cod_produto int primary key auto_increment,
Nome_produto varchar (70),
preco_produto float(10,2)
);

create table perfil(
	Cod_perfil int primary key auto_increment,
    cargo varchar(70)
);

create table usuario(
	Cod_usuario int primary key auto_increment,
	Nome_user varchar(70),
    idade_user int,
    foto_user varchar(200),
    data_Registro date,
    horario_Registro time,
    UserName varchar(70),
    senha varchar(90),
    CFK_prod int,
    CFK_perfil int,
    constraint FK_prod foreign key (CFK_prod) references produto(Cod_prod),
    constraint FK_perfil foreign key (CFK_perfil) references perfil(Cod_perfil)
);

create table Historico_pedidos(
	Cod_hist int primary key auto_increment,
    dia_ped date,
    hora_ped time,
    CFK_prod int,
    CFK_User int,
    constraint FK_user foreign key (CFK_User) references usuario(Cod_usuario),
    constraint FK_prod foreign key (CFK_prod)references produto(Cod_prod)
);

insert into perfil(cargo) values("ADM"), ("Gerente"), ("Cliente"),("Revendedor"),("Técnico");
insert into fornecedor(nome_fornc, Local_trabalho) values ("Adam", "SESI"), ("Gabriel", "SENAI"), ("Rafael", "FIEP");
insert into produto(Nome_prod, preco_prod) values("Servidor HP Proliant DL360", 12600.00), ("Servidor Dell PowerEdge R720", 10000.00), ("Servidor HP Proliant ML350 G8", 5100.00), ("Servidor Dell PowerEdge T630", 13000.00), ("Servidor Dell PowerEdge R420", 6200.00), ("Servidor Hp Proliant DL380 G7", 4200.00), ("Servidor Dell PowerEdge R740", 25300.00), ("Servidor Dell PowerEdge R450", 16450.00);
insert into produto_soft(Nome_produto, preco_produto) values ("Software Word Pacote Office",791.00), ("Software Powerpoint Pacote Office",791.00), ("Software Excel Pacote Office",791.00), ("Software OneNote Pacote Office",791.00), ("Software Outlook Pacote Office",791.00),  ("Asssinatura Mensal Pessoal Office 365",7.00),("Asssinatura Mensal Family Office 365",9.00),("Asssinatura Anual Family Office 365",72.00);

select * from fornecedor;
select * from produto;
select * from perfil;
select * from usuario;
SELECT * FROM produto_soft;
-- select * from



