use carreras
GO

insert into Carreras (nombre_carrera,titulo_carrera,anio_maximo)
values ('Tecnicatura Universitaria en Programacion','Tecnico/a Universitario/a en Programacion',2)

--INSERT DE ASGINATURA 1er Cuatrimestre
insert into Asignaturas (nombre_asignatura)
values ('Matematica')
insert into Asignaturas (nombre_asignatura)
values ('Ingles I')
insert into Asignaturas (nombre_asignatura)
values ('Sistemas de Procesamiento de Datos')
insert into Asignaturas (nombre_asignatura)
values ('Laboratorio de Computacion I')
insert into Asignaturas (nombre_asignatura)
values ('Programacion I')

--INSERT DE ASGINATURA 2do Cuatrimestre
insert into Asignaturas (nombre_asignatura)
values ('Programacion II')
insert into Asignaturas (nombre_asignatura)
values ('Arquitectura y Sistemas Operativos')
insert into Asignaturas (nombre_asignatura)
values ('Estadistica')
insert into Asignaturas (nombre_asignatura)
values ('Ingles II')
insert into Asignaturas (nombre_asignatura)
values ('Laboratorio de Computacion II')
insert into Asignaturas (nombre_asignatura)
values ('Metodologia de la Investigacion')

--INSERT Detalle_carrera Materias 1er Cuatrimestre 1er anio
insert into Detalles_carrera(id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(1,1,'P',1)
insert into Detalles_carrera(id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(1,1,'P',2)
insert into Detalles_carrera(id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(1,1,'P',3)
insert into Detalles_carrera(id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(1,1,'P',4)
insert into Detalles_carrera(id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(1,1,'P',5)

--INSERT Detalle_carrera Materias 2do Cuatrimestre 1er anio
insert into Detalles_carrera(id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(1,1,'S',6)
insert into Detalles_carrera(id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(1,1,'S',7)
insert into Detalles_carrera(id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(1,1,'S',8)
insert into Detalles_carrera(id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(1,1,'S',9)
insert into Detalles_carrera(id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(1,1,'S',10)
insert into Detalles_carrera(id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(1,1,'S',11)

----------------SEGUNDO ANIO-----------------------------

--INSERT DE ASGINATURA 1er Cuatrimestre 2do anio
insert into Asignaturas (nombre_asignatura)
values ('Programacion III')
insert into Asignaturas (nombre_asignatura)
values ('Organizacion Contable de la Empresa')
insert into Asignaturas (nombre_asignatura)
values ('Organizacion Empresarial')
insert into Asignaturas (nombre_asignatura)
values ('Elementos de Investigacion Operativa')
insert into Asignaturas (nombre_asignatura)
values ('Laboratorio de Computacion III')

--INSERT DE ASGINATURA 2do Cuatrimestre 2do anio
insert into Asignaturas (nombre_asignatura)
values ('Metodologia de Sistemas I')
insert into Asignaturas (nombre_asignatura)
values ('Disenio y Administracion de Bases de Datos')
insert into Asignaturas (nombre_asignatura)
values ('Legislacion')
insert into Asignaturas (nombre_asignatura)
values ('Laboratorio de Computacion IV')

--INSERT Detalle_carrera Materias 1er Cuatrimestre 2do anio
insert into Detalles_carrera(id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(1,2,'P',12)
insert into Detalles_carrera(id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(1,2,'P',13)
insert into Detalles_carrera(id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(1,2,'P',14)
insert into Detalles_carrera(id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(1,2,'P',15)
insert into Detalles_carrera(id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(1,2,'P',16)

--INSERT Detalle_carrera Materias 2do Cuatrimestre 2do anio

insert into Detalles_carrera(id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(1,2,'S',17)
insert into Detalles_carrera(id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(1,2,'S',18)
insert into Detalles_carrera(id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(1,2,'S',19)
insert into Detalles_carrera(id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(1,2,'S',20)

--TECNICATURA UNIVERSITARIA EN MANTENIMIENTO INDUSTRIAL

insert into Carreras (nombre_carrera,titulo_carrera,anio_maximo)
values ('Tecnicatura Universitaria en Mantenimiento Industrial','Tecnico/a Universitario/a en Mantenimiento Industrial',2)

--Materias de primer anio
--Primer cuat

insert into Asignaturas (nombre_asignatura) values ('Mantenimiento Industrial I')
insert into Asignaturas (nombre_asignatura) values ('Electrotecnia')
insert into Asignaturas (nombre_asignatura) values ('Matematica')
insert into Asignaturas (nombre_asignatura) values ('Quimica')
insert into Asignaturas (nombre_asignatura) values ('Relaciones Industriales')
insert into Asignaturas (nombre_asignatura) values ('Informatica I')

insert into Detalles_carrera (id_carrera, anio_cursado, cuatrimestre, id_asignatura)
values (2,1,'A',21)
insert into Detalles_carrera (id_carrera, anio_cursado, cuatrimestre, id_asignatura)
values (2,1,'A',22)
insert into Detalles_carrera (id_carrera, anio_cursado, cuatrimestre, id_asignatura)
values (2,1,'P',23)
insert into Detalles_carrera (id_carrera, anio_cursado, cuatrimestre, id_asignatura)
values (2,1,'P',24)
insert into Detalles_carrera (id_carrera, anio_cursado, cuatrimestre, id_asignatura)
values (2,1,'P',25)
insert into Detalles_carrera (id_carrera, anio_cursado, cuatrimestre, id_asignatura)
values (2,1,'P',26)
--Segundo cuat

insert into Asignaturas (nombre_asignatura) values ('Mecanica II')
insert into Asignaturas (nombre_asignatura) values ('Sistema de Representacion')
insert into Asignaturas (nombre_asignatura) values ('Conocimientos de los materiales')
insert into Asignaturas (nombre_asignatura) values ('Neumatica e Hidraulica')

insert into Detalles_carrera (id_carrera, anio_cursado, cuatrimestre, id_asignatura)
values (2,1,'S',27)
insert into Detalles_carrera (id_carrera, anio_cursado, cuatrimestre, id_asignatura)
values (2,1,'S',28)
insert into Detalles_carrera (id_carrera, anio_cursado, cuatrimestre, id_asignatura)
values (2,1,'S',29)
insert into Detalles_carrera (id_carrera, anio_cursado, cuatrimestre, id_asignatura)
values (2,1,'S',30)

--Materias de segundo anio
--Primer cuat

insert into Asignaturas (nombre_asignatura) values ('Mantenimiento Industrial II')
insert into Asignaturas (nombre_asignatura) values ('Elementos de Maquinas')
insert into Asignaturas (nombre_asignatura) values ('Tecnologia de Frio y Calor')
insert into Asignaturas (nombre_asignatura) values ('Instalaciones y Maquinas Eléctricas')
insert into Asignaturas (nombre_asignatura) values ('Informatica II')
insert into Asignaturas (nombre_asignatura) values ('Elementos de Automatizacion')
insert into Asignaturas (nombre_asignatura) values ('Ingles')

insert into Detalles_carrera (id_carrera, anio_cursado, cuatrimestre, id_asignatura)
values (2,2,'A',31)
insert into Detalles_carrera (id_carrera, anio_cursado, cuatrimestre, id_asignatura)
values (2,2,'A',32)
insert into Detalles_carrera (id_carrera, anio_cursado, cuatrimestre, id_asignatura)
values (2,2,'A',33)
insert into Detalles_carrera (id_carrera, anio_cursado, cuatrimestre, id_asignatura)
values (2,2,'A',34)
insert into Detalles_carrera (id_carrera, anio_cursado, cuatrimestre, id_asignatura)
values (2,2,'P',35)
insert into Detalles_carrera (id_carrera, anio_cursado, cuatrimestre, id_asignatura)
values (2,2,'P',36)
insert into Detalles_carrera (id_carrera, anio_cursado, cuatrimestre, id_asignatura)
values (2,2,'P',37)

--Segundo cuat

insert into Asignaturas (nombre_asignatura) values ('Seguridad Higiene y Proteccion Ambiental')
insert into Asignaturas (nombre_asignatura) values ('Costos y Control de Gestion')
insert into Asignaturas (nombre_asignatura) values ('Aseguramiento de la Calidad')

insert into Detalles_carrera (id_carrera, anio_cursado, cuatrimestre, id_asignatura)
values (2,2,'S',38)
insert into Detalles_carrera (id_carrera, anio_cursado, cuatrimestre, id_asignatura)
values (2,2,'S',39)
insert into Detalles_carrera (id_carrera, anio_cursado, cuatrimestre, id_asignatura)
values (2,2,'S',40)


Insert into Carreras (nombre_carrera,titulo_carrera,anio_maximo)
values('Tecnicatura Universitaria en Industrias','Tecnico/a Universitario/a en Industrias',2)

insert into Asignaturas (nombre_asignatura)
values ('Indutria Alimnetaria I')
insert into Asignaturas (nombre_asignatura)
values('Biologia General')
insert into Asignaturas (nombre_asignatura)
values ('Matematica General')
insert into Asignaturas (nombre_asignatura)
values ('Quimica General')
insert into Asignaturas (nombre_asignatura)
values('Física')
insert into Asignaturas (nombre_asignatura)
values('Química Analitica')
insert into Asignaturas (nombre_asignatura)
values('Química Inorganica')
insert into Asignaturas (nombre_asignatura)
values('Industrias Alimentarias II')
insert into Asignaturas (nombre_asignatura)
values('Legislacion Sanitaria')
insert into Asignaturas (nombre_asignatura)
values('Microbiologia de los Alimentos')
insert into Asignaturas (nombre_asignatura)
values('Química Orgánica')
insert into Asignaturas (nombre_asignatura)
values('Economía')
insert into Asignaturas (nombre_asignatura)
values('Estadística')
insert into Asignaturas (nombre_asignatura)
values('Bromatología')

insert into Detalles_carrera (id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(3,1,'A',41)--INDUSTRIA ALIMENTARIA
insert into Detalles_carrera (id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(3,1,'P',42)--BIOLOGIA GENERAL
insert into Detalles_carrera (id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(3,1,'P',43)--MATEMATICA GENERAL
insert into Detalles_carrera (id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(3,1,'P',44)--QUIMICA GENERAL
insert into Detalles_carrera (id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(3,1,'S',45)--FISICA
insert into Detalles_carrera (id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(3,1,'S',46)--QUIMICA ANALITA
insert into Detalles_carrera (id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(3,1,'S',47)---QUIMICA INORGANICA
insert into Detalles_carrera (id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(3,2,'A',48)--INSDUTRIAS ALIMENTARIAS II
insert into Detalles_carrera (id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(3,2,'A',49)--LEGISTLACION SANITARIA
insert into Detalles_carrera (id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(3,2,'A',50)--MICROBIOLOGIA DE LOS ALIMENTOS II
insert into Detalles_carrera (id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(3,2,'P',51)--QUIMICA ORGANICA
insert into Detalles_carrera (id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(3,2,'P',52)--ECONOMIA
insert into Detalles_carrera (id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(3,2,'S',53)--ESTADISTICA
insert into Detalles_carrera (id_carrera,anio_cursado,cuatrimestre,id_asignatura)
values(3,2,'S',54)--BROMATOLOGIA

--usuarios
insert into Usuarios values ('grupo16','changuito')