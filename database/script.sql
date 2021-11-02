use carreras
GO

--crear nueva carrera
create procedure SP_CREATE_CARRERAS
@nombre varchar(70),
@titulo varchar(70),
@anio_maximo tinyint
as
	insert into Carreras (nombre_carrera,titulo_carrera,anio_maximo)
	values (@nombre,@titulo,@anio_maximo)
go

--consultar carreras
create procedure SP_READ_CARRERAS
as
	select * from carreras
go

--consultar carreras por id
create procedure SP_READ_CARRERAS_BY_ID
(@id_carrera int)
as
	select * from Carreras c
	join Detalles_carrera dt on dt.id_carrera = c.id_carrera
	join Asignaturas a on a.id_asignatura = dt.id_asignatura
	where c.id_carrera = @id_carrera
go

--actualizar carreras
create procedure SP_UPDATE_CARRERAS
(@id_carrera int,
@nombre varchar(70),
@titulo varchar(70),
@anio_maximo tinyint)
as
	update Carreras 
	set nombre_carrera = @nombre,
		titulo_carrera = @titulo,
		anio_maximo = @anio_maximo
	where id_carrera = @id_carrera
go

--borrar carrera
create procedure SP_DELETE_CARRERAS
(@id_carrera int)
as
	delete Carreras where id_carrera = @id_carrera
go

--crear nuevo detalle
create procedure SP_CREATE_DETALLES
(@id_carrera int,
@anio_cursado tinyint,
@cuatrimestre varchar(1),
@id_asignatura int)
as
	insert into Detalles_carrera (id_carrera,anio_cursado,cuatrimestre,id_asignatura)
	values (@id_carrera, @anio_cursado, @cuatrimestre, @id_asignatura)
go

--leer un detalle
create procedure SP_READ_DETALLES
(@id_carrera int)
as
	select * from Detalles_carrera dc
	join Asignaturas a on dc.id_asignatura = a.id_asignatura
	where id_carrera = @id_carrera
go

--actualizar detalle
create procedure SP_UPDATE_DETALLES
(@id_detalle int,
@anio_cursado tinyint,
@cuatrimestre varchar(1),
@id_asignatura int)
as
	update Detalles_carrera
	set anio_cursado = @anio_cursado,
		cuatrimestre = @cuatrimestre,
		id_asignatura = @id_asignatura
	where id_detalle = @id_detalle
go

--borrar un detalle
create procedure SP_DELETE_DETALLES
(@id_detalle int)
as
	delete Detalles_carrera where id_detalle = @id_detalle
go

--borrar todos los detalles de una carrera
create procedure SP_DELETE_DETALLES_BY_CARRERA
(@id_carrera int)
as
	delete Detalles_Carrera
	where id_carrera = @id_carrera
go

--crear nueva asignatura
create procedure SP_CREATE_ASIGNATURAS
@nombre varchar(60)
as
	insert into Asignaturas (nombre_asignatura)
	values (@nombre)
go

--consultar asignaturas
create procedure SP_READ_ASIGNATURAS
as
	select * from Asignaturas
go

--actualizar asignaturas
create procedure SP_UPDATE_ASIGNATURAS
(@id_asignatura int,
@nombre_asignatura varchar(60))
as
	update Asignaturas set nombre_asignatura = @nombre_asignatura where id_asignatura = @id_asignatura
go

--eliminar asignaturas
create procedure SP_DELETE_ASIGNATURAS
(@id_asignatura int)
as
	delete Asignaturas where id_asignatura = @id_asignatura
go

--login
create procedure SP_LOGIN
(@nom_usuario varchar(32),
@contrasenia varchar(128))
as
	select * from Usuarios where @nom_usuario = nom_usuario and @contrasenia = contrasenia
go

--traer siguiente num
CREATE PROCEDURE [dbo].[SP_PROXIMO_ID]
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT (IDENT_CURRENT ('Carreras'))+1);
	return @next
END
GO