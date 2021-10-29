create database carreras
go
use carreras
go

create table Carreras
(id_carrera int identity,
nombre_carrera varchar(70),
titulo_carrera varchar(70),
anio_maximo tinyint,
constraint pk_carrera primary key (id_carrera)
)

create table Asignaturas
(
id_asignatura int identity,
nombre_asignatura varchar(60)
constraint pk_asignaturas primary key (id_asignatura)
)

create table Detalles_carrera
(
id_detalle int identity,
id_carrera int,
anio_cursado tinyint,
cuatrimestre varchar(1),
id_asignatura int
constraint pk_detalle_carrera primary key (id_detalle),
constraint fk_carrera_detalle foreign key (id_carrera)
references Carreras (id_carrera),
constraint fk_detalle_asig foreign key (id_asignatura)
references Asignaturas (id_asignatura)
)

create table Usuarios
(
id_usuario int identity,
nom_usuario varchar(32),
contrasenia varchar(128)
constraint pk_usuarios primary key (id_usuario)
)
