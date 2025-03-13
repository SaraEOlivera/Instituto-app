
Create Table Alumno 
(
	IdAlumno int Identity,
	NombreEst varchar(30),
	ApellidoEst varchar(40),
	DocumentoEst varchar(15) Unique,
	IdPostulante int,
	Constraint PK_Estudiante Primary Key (IdAlumno),
)

Create Table Docente
(
	IdDoc int Identity,
	NombreDoc varchar(20),
	ApellidoDoc varchar(30),
	DocumentoDoc varchar(15) Unique,
	Constraint PK_Docente Primary Key (IdDoc)
)

Create Table Curso
(
	IdCurso int Identity,
	NombreCurso varchar(100),
	PrecioCurso money,
	Cupo int,
	IdDocente int,
	Constraint PK_Curso Primary Key (IdCurso),
	Constraint FK_Curso_Docente Foreign Key (IdDocente) references Docente(IdDoc)
)

Create Table Inscripcion
(
	IdInscrip int Identity,
	IdAlumno int,
	IdCurso int,
	EstadoInscripcion varchar(15) default 'Pendiente',
	FechaInscripcion datetime default GetDate(),
	Constraint PK_Inscripcion Primary Key (IdInscrip),
	Constraint FK_Inscripcion_Alumno Foreign Key (IdAlumno) references Alumno (IdAlumno),
	Constraint FK_Inscripcion_Curso Foreign Key (IdCurso) references Curso (IdCurso),
	Constraint CHK_EstadoInscripcion Check (EstadoInscripcion in ('Pendiente', 'Confirmada', 'Rechazada')) 
)
Create Table Pago
(
	IdPago int Identity,
	ImportePago money not null,
	FechaPago datetime default GetDate(),
	FormaPago varchar(40) not null,
	IdCurso int not null,
	IdAlumno int not null,
	Constraint PK_Pago Primary Key (IdPago),
	Constraint FK_Pago_Curso Foreign Key (IdCurso) references Curso (IdCurso),
	Constraint FK_Pago_Alumno Foreign Key (IdAlumno) references Alumno (IdAlumno)
)
-- Tablas de Interseccion

-- Estudiante-Curso : Se utiliza tabla Inscripcion
-- Docente-Curso : Cada curso tiene solo un docente; un docente dicta muchos cursos pero cada curso es dictado por solo un docente
-- Postulante-Estudiante : No hace falta tabla intermedia ya que en la tabla Inscripcion está el campo Estado para confirmar si se logró la inscripcion del postulante al curso. 


