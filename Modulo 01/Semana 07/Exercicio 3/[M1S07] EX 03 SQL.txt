create table produto (
id int identity(1,1) primary key, 
nome varchar(30) not null, 
preco int check (preco > 50) , 
tamanho varchar(3)  
);

create table pedidos (
id int identity(1,1) primary key,
data_pedido date not null, 
forma_pagamento varchar(20) not null,
logradouro varchar(20) not null, 
numero int not null, 
cidade varchar(20) not null, 
uf char(2) not null, 
pais varchar(20) not null
);

create table produto_pedidos (
id int identity(1,1)  primary key,
id_produto int,
id_pedidos int,
constraint fk_prod_pedidos foreign key (id_produto) references produto (id), 
constraint fk2_prod_pedidos foreign key (id_pedidos) references pedidos (id)
);
