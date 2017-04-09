
CREATE  database GESTIONDEAULA

USE GESTIONDEAULA;

CREATE TABLE USUARIO
(
ID int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(50) NULL,
Cedula varchar(15) NOT NULL,
Estado varchar(15) NULL,
Fecha_Creado datetime null,
Creado_Por int null,
Fecha_Actualizado datetime null,
Actualizado_Por int null
)


CREATE TABLE ESTUDIANTE
(
ID int IDENTITY(1,1) PRIMARY KEY,
ID_Usuario int NOT NULL,
No_Carnet varchar(100) not NULL,
Contrasena varchar(255) not null,
Tanda varchar(15) null,
Estado varchar(15) NULL,
Fecha_Creado datetime null,
Creado_Por int null,
Fecha_Actualizado datetime null,
Actualizado_Por int null
)
ALTER TABLE ESTUDIANTE ADD CONSTRAINT Estudiante_ID_Usuario_fk 
FOREIGN KEY (ID_Usuario) REFERENCES USUARIO (ID)


CREATE TABLE TANDA
(
ID int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(15),
Descripcion varchar(255) NULL,
Fecha_Creado datetime null,
Creado_Por int null,
Fecha_Actualizado datetime null,
Actualizado_Por int null
)


CREATE TABLE EMPLEADO
(
ID int IDENTITY(1,1) PRIMARY KEY,
ID_Usuario int NOT NULL,
No_Carnet varchar(100) not NULL,
Contrasena varchar(255) not null,
Tanda_Laboral varchar(15),
Estado varchar(15) NULL,
Fecha_Creado datetime null,
Creado_Por int null,
Fecha_Actualizado datetime null,
Actualizado_Por int null
)
ALTER TABLE EMPLEADO ADD CONSTRAINT Empleado_ID_Usuario_fk
FOREIGN KEY (ID_Usuario) REFERENCES USUARIO (ID);


CREATE TABLE PROFESOR
(
ID int IDENTITY(1,1) PRIMARY KEY,
ID_Usuario int NOT NULL,
No_Carnet varchar(100) not NULL,
Contrasena varchar(255) not null,
Tanda_Laboral varchar(15)  null,
Estado varchar(15) NULL,
Fecha_Creado datetime null,
Creado_Por int null,
Fecha_Actualizado datetime null,
Actualizado_Por int null
)
ALTER TABLE PROFESOR ADD CONSTRAINT Profesor_ID_Usuario_fk
FOREIGN KEY (ID_Usuario) REFERENCES USUARIO (ID);


CREATE TABLE CAMPUS
(
ID int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(75) NULL,
Descripcion varchar(255) NULL,
Estado varchar(15) NULL,
Fecha_Creado datetime null,
Creado_Por int null,
Fecha_Actualizado datetime null,
Actualizado_Por int null
)


CREATE TABLE EDIFICIO
(
ID int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(75) NULL,
Descripcion varchar(255) NULL,
ID_Campus int not null,
Estado varchar(15) NULL,
Fecha_Creado datetime null,
Creado_Por int null,
Fecha_Actualizado datetime null,
Actualizado_Por int null
)
ALTER TABLE EDIFICIO ADD 
CONSTRAINT Edificio_ID_Campus_fk FOREIGN KEY (ID_Campus) REFERENCES CAMPUS(ID)



CREATE TABLE TIPO_AULA
(
ID int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(100) NULL,
Descripcion varchar(255) NULL,
Fecha_Creado datetime null,
Creado_Por int null,
Fecha_Actualizado datetime null,
Actualizado_Por int null
)

CREATE TABLE AULA
(
ID int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(100) NULL,
Descripcion varchar(250) NULL,
Tipo varchar(15) NULL,
ID_Edificio int not null,
Estado varchar(15) NULL,
Fecha_Creado datetime null,
Creado_Por int null,
Fecha_Actualizado datetime null,
Actualizado_Por int null
)
ALTER TABLE AULA ADD CONSTRAINT Aula_ID_Edificio_fk
FOREIGN KEY (ID_Edificio) REFERENCES EDIFICIO(ID)


CREATE TABLE DETALLE_AULA
(
ID int IDENTITY(1,1) PRIMARY KEY,
ID_Aula int not NULL,
Capacidad_Reservacion int NULL,
Cantidad_Reservacion int null
)
ALTER TABLE DETALLE_AULA ADD CONSTRAINT Detalle_Aula_ID_Aula_fk
FOREIGN KEY (ID_Aula) REFERENCES AULA(ID)



CREATE TABLE ESTADO
(
ID int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(100) NULL
)
INSERT INTO ESTADO (Nombre) VALUES
('ACTIVO'),
('INACTIVO')


CREATE TABLE TIPO_USUARIO
(
ID int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(100) NULL
)
INSERT INTO TIPO_USUARIO (Nombre) VALUES
('ESTUDIANTE'),
('EMPLEADO'),
('PROFESOR')



CREATE TABLE EJECUCION
(
ID int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(100) NULL
)
INSERT INTO EJECUCION (Nombre) VALUES
('ABIERTO'),
('CERRADO'),
('CANCELADO')



CREATE TABLE MODULO
(
ID int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(100) NULL
)
INSERT INTO MODULO (Nombre) VALUES
('USUARIO'),
('ESTUDIANTE'),
('PROFESOR'),
('EMPLEADO'),
('CAMPUS'),
('EDIFICIO'),
('AULA'),
('TIPO_AULA'),
('DETALLE_AULA'),
('TANDA'),
('ROL'),
('ASIGNAR_PERMISO_ROL'),
('ASIGNAR_ROL_USUARIO'),
('SOLICITUD'),
('GESTION'),
('CONFIGURACION')




CREATE TABLE ROL
(
ID int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(100) NULL,
Descripcion varchar(250) NULL,
Estado varchar(15) NULL,
Fecha_Creado datetime null,
Creado_Por int null,
Fecha_Actualizado datetime null,
Actualizado_Por int null
)


CREATE TABLE ASIGNAR_PERMISO_ROL
(
ID int IDENTITY(1,1) PRIMARY KEY,
ID_Rol int NOT NULL,
ID_Modulo int NOT NULL
)
ALTER TABLE ASIGNAR_PERMISO_ROL ADD 
CONSTRAINT Asignar_Permiso_Rol_ID_Rol_fk FOREIGN KEY (ID_Rol) REFERENCES ROL(ID),
CONSTRAINT Asignar_Permiso_Rol_ID_Modulo_fk FOREIGN KEY (ID_Modulo) REFERENCES MODULO(ID)


CREATE TABLE ASIGNAR_ROL_USUARIO
(
ID int IDENTITY(1,1) PRIMARY KEY,
ID_Usuario int NOT NULL,
ID_Rol int NOT NULL
)
ALTER TABLE ASIGNAR_ROL_USUARIO ADD 
CONSTRAINT Asignar_Rol_Usuario_ID_Usuario_fk FOREIGN KEY (ID_Usuario) REFERENCES USUARIO(ID),
CONSTRAINT Asignar_Rol_Usuario_ID_Rol_fk FOREIGN KEY (ID_Rol) REFERENCES ROL(ID)


CREATE TABLE SOLICITUD
(
ID int IDENTITY(1,1) PRIMARY KEY,
ID_Usuario int not NULL,
ID_Aula int not null,
Fecha_Reservacion datetime null,
Cantidad_Hora int null,
Fecha_Creado datetime null,
Fecha_Inicio datetime null,
Comentario varchar(255) null,
Estado varchar(15),
Ejecucion varchar(15)
)
ALTER TABLE SOLICITUD ADD 
CONSTRAINT Solicitud_ID_Aula_fk FOREIGN KEY (ID_Aula) REFERENCES AULA(ID),
CONSTRAINT Solicitud_ID_Usuario_fk FOREIGN KEY (ID_Usuario) REFERENCES USUARIO(ID)



CREATE TABLE DETALLE_SOLICITUD
(
ID int IDENTITY(1,1) PRIMARY KEY,
ID_Solicitud int NOT NULL,
ID_Empleado int not NULL,
Comentario varchar(255) NULL
)
ALTER TABLE DETALLE_SOLICITUD ADD 
CONSTRAINT Detalle_Solicitud_ID_Solicitud_fk FOREIGN KEY (ID_Solicitud) REFERENCES SOLICITUD(ID),
CONSTRAINT Detalle_Solicitud_ID_Empleado_fk FOREIGN KEY (ID_Empleado) REFERENCES EMPLEADO(ID)



create function ufnReporteSolicitud()
returns table
as 
return 
(

Select 
SOLICITUD.ID as Solicitud
,USUARIO.Nombre as Usuario
,USUARIO.Cedula as Cedula
,CAMPUS.Nombre as Campus 
,EDIFICIO.Nombre as Edificio 
,AULA.Nombre as Aula
,AULA.Tipo as Tipo_Aula
,SOLICITUD.Fecha_Reservacion
, dateadd(hour, cantidad_hora, Fecha_reservacion) as Fecha_Fin 
,SOLICITUD.Cantidad_Hora
,SOLICITUD.Estado
,SOLICITUD.Ejecucion


from SOLICITUD 
inner join AULA on SOLICITUD.ID_Aula = aula.ID
inner join EDIFICIO on AULA.ID_Edificio = EDIFICIO.ID
inner join CAMPUS on EDIFICIO.ID_Campus = CAMPUS.ID 
inner join USUARIO on SOLICITUD.ID_Usuario = USUARIO.ID

)