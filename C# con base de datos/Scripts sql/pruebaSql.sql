use master
go
create database db_telefonos
go
use
db_telefonos
go
--Creando la tabla:

create table tbl_telefono
(
nombre varchar (30) not null,
direccion varchar(30) not null,
telefono  varchar(12) not null primary key,
observaciones varchar(240) default 'Ninguna');
go

--Insercion de datos:
insert into tbl_telefono values 
('Leticia Aguirre Soriano','Triana, Sevilla','954345678',default),
('Pedro Aguado Rodriguez','Alcala de Henares, Madrid','918888888',default)
go


create procedure sp_consultaXprefijo(@prefijo varchar(30))
as
	begin
		select nombre ,telefono from tbl_telefono
		where telefono like(@prefijo+'%')
	end
go


create procedure sp_modificarTel(@tfnNuevo varchar(12), @tfnViejo varchar(12))
as
	begin
		update tbl_telefono
		set telefono=@tfnNuevo
		where telefono=@tfnViejo;
	end
go

