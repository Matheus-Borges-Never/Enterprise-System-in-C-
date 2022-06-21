create database sistema

create table empresa(
id_empresa int primary key identity(1,1),
nome varchar (200) not null,
endereco varchar (60) not null,
complemento varchar (30),
cep numeric (8) not null,
numero varchar (5) not null,
telefone numeric (13) not null,
) 

create table funcionario(
id_funcionario int primary key identity(1,1),
nome varchar (200) not null,
cargo varchar (13) not null,
salario numeric (15) not null,
)

create table ligacao(
id_aluga int primary key identity(1,1),
id_empresa int not null,
id_funcionario int not null,
constraint fk_empresa
foreign key (id_empresa)
references empresa (id_empresa),
constraint fk_funcionario
foreign key (id_funcionario)
references funcionario (id_funcionario)
)

insert into empresa values('Teste','Rua José - Centro Franca/SP','Ap 303',14403830,'4100',16991245252)

select * from empresa