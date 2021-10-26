create database carreras
go
use carreras
go

create table Carreras
(id_carrera int identity,
nombre_titulo varchar(60)
constraint pk_carrera primary key (id_carrera)
)

create table Asignaturas
(
id_asignatura int identity,
nombre varchar(40)
constraint pk_asignaturas primary key (id_asignatura)
)

create table Detalles_carrera
(
id_detalle int identity,
id_carrera int,
anio_cursado tinyint,
cuatrimestre char(1),
id_asignatura int
constraint pk_detalle_carrera primary key (id_detalle),
constraint fk_carrera_detalle foreign key (id_carrera)
references Carreras (id_carrera),
constraint fk_detalle_asig foreign key (id_asignatura)
references Asignaturas (id_asignatura)
)
go