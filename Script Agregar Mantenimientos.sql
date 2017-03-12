create table Tipo_Usuario
(
Identificador int not null primary key,
Nombre varchar(50),
Descripcion varchar(250)
)

create table Estado_Usuario
(
Identificador int not null primary key,
Nombre varchar(50),
Descripcion varchar(250)
)

create table Tanda
(
Identificador int not null primary key,
Nombre varchar(50),
Descripcion varchar(250)
)


insert into Tipo_Usuario values (1,'Estudiante','')
insert into Tipo_Usuario values (2,'Empleado','')


insert into Estado_Usuario values (1,'Activo','')
insert into Estado_Usuario values (2,'Inactivo','')

insert into Tanda values (1,'Mañana','')
insert into Tanda values (2,'Tarde','')
insert into Tanda values (3,'Noche','')

