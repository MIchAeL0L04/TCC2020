Create database TCC_SEMIK;
use TCC_SEMIK;

create table funcionario(
cod_funcio int primary key auto_increment,
nome_funcio varchar (50),
usuario_funcio varchar (10),
telefone varchar (11),
email varchar (50),
permissao varchar (1),
senha varchar (8)
);

select * from funcionario;