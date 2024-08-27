use AulaADO
--Clientes (ID, Nome, DataNascimento)
create table Clientes
(ID int identity not null primary key, Nome varchar(50) not null, DataNascimento date null);

select * from Clientes
