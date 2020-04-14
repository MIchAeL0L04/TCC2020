Create database TCC_SEMIK;
use TCC_SEMIK;

/*FUNCIONARIO*/
create table funcionario(
cod_funcio int primary key auto_increment,
nome_funcio varchar (50),
usuario_funcio varchar (10),
telefone varchar (11),
email varchar (50),
permissao varchar (1),
senha varchar (8)
);

insert into funcionario values (
default,
"leonardo",
'leonhard',
'953208802',
'leonardo@semik.com',
'1',
'12345');

CREATE TABLE DetalhePedido(
	ID int auto_increment NOT NULL,
	IdPedido int NOT NULL,
	PrecoTotal decimal(18, 2) NOT NULL,
	IdModoDePag int NOT NULL

);

CREATE TABLE ModoDePag(
	ID int auto_increment NOT NULL,
	Descricao varchar(50) NOT NULL
);


CREATE TABLE Pedido(
	ID int auto_increment NOT NULL,
    Atendido bit NOT NULL,
    Detalhe varchar(50) NOT NULL,
    IdFuncionario varchar(50) NOT NULL
    /*ID modo de pagamento foreign key?*/
);

CREATE TABLE Produto(
	ID int auto_increment NOT NULL,
	Nome varchar(50) NOT NULL,
	IdTipoProduto int NOT NULL,
	Preco decimal(18, 2) NOT NULL,
	Descricao varchar(100) NOT NULL
	/*imagem varchar(50) NULL*/
    /*Fazer foreign key da tabela TipoProduto*/
);

CREATE TABLE ProdutosPedidos(
	ID int auto_increment NOT NULL,
	IdProduto int NOT NULL,
	IdPedido int NOT NULL,
	Observacao varchar(50) NULL
);

CREATE TABLE TipoProduto(
	ID int auto_increment NOT NULL,
	Descricao varchar(30) NOT NULL
);
select * from funcionario;