Select * from Docente
Insert into Docente Values 
('Nilda','Perez', 21021021),
('Carlos','Lipis',19452452),
('Walter','Rodriguez',12123123),
('Olivia','Quiroz',23120120),
('Maria Ines','Urtufart',24111000),
('Miriam','Rojas',21000000),
('Josefina','Juarez',35896698)

Select * from Curso

--Insert into Curso(NombreCurso, PrecioCurso, Cupo, IdDocente)
--Select NombreCurso, PrecioCurso, Cupo,
--	(Select Top 1 IdDoc from Docente order by NewId())
--from (values
--('Programacion I',4189, 20),
--('Programacion II', 4190, 25),
--('Programacion III', 4191,10),
--('Calculo numerico', 3258, 15),
--('Analisis Matematico I', 3893, 5),
--('Analisis Matematico II', 3894, 2),
--('Algebra I', 2581, 8),
--('Algebra II', 2582, 1),
--('Inglés Básico', 3751, 9),
--('Ingles medio', 3752, 11),
--('Ingles avanzado', 3753, 4)
--) as Cursos (NombreCurso, PrecioCurso, Cupo);

Truncate table Curso;

--With IdDocenteAleatorio as (
--	Select IdDoc, ROW_NUMBER() over (Order by NewID()) As Rownum
--	from Docente
--)
--Insert into Curso (NombreCurso, PrecioCurso, Cupo, IdDocente)
--Select NombreCurso, PrecioCurso, Cupo, IdDoc From
--(
--	Values 
--		('Programacion I',4189, 20),
--		('Programacion II', 4190, 25),
--		('Programacion III', 4191,10),
--		('Calculo numerico', 3258, 15),
--		('Analisis Matematico I', 3893, 5),
--		('Analisis Matematico II', 3894, 2),
--		('Algebra I', 2581, 8),
--		('Algebra II', 2582, 1),
--		('Inglés Básico', 3751, 9),
--		('Ingles medio', 3752, 11),
--		('Ingles avanzado', 3753, 4)
--) as Cursos (NombreCurso, PrecioCurso, Cupo)
--Join IdDocenteAleatorio IdDoc 
--on IdDoc.Rownum = (Select Top 1 ROW_NUMBER() over (order by NewId()) from Docente)

Select * from curso

-- 1 - Crear una tabla temporal para almacenar 
--los IdDocentes en orden aleatorio:

CREATE TABLE #IdDocenteTemporal (IdDocente INT, Rownum INT);

-- 2 - Insertar IdDocente de forma aleatoria 

INSERT INTO #IdDocenteTemporal (IdDocente, Rownum)
SELECT IdDoc, ROW_NUMBER() OVER (ORDER BY NEWID()) FROM Docente;

-- 3 - Crear otra tabla temporal para los cursos
CREATE TABLE #Cursos (
    IdCurso INT IDENTITY(1,1),
    NombreCurso VARCHAR(255),
    PrecioCurso INT,
    Cupo INT
);

-- 4 - Insertar los cursos en la tabla temporal
-- Solo 7 porque son 7 idDocente y NewId(hace que no se repitan ver word)
INSERT INTO #Cursos (NombreCurso, PrecioCurso, Cupo)
VALUES
('Programacion I',4189, 20),
('Programacion II', 4190, 25),
('Programacion III', 4191,10),
('Calculo numerico', 3258, 15),
('Analisis Matematico I', 3893, 5),
('Analisis Matematico II', 3894, 2),
('Algebra I', 2581, 8);

-- 5 - Insertar en la tabla Curso asignando un docente aleatorio
--a cada curso
INSERT INTO Curso (NombreCurso, PrecioCurso, Cupo, IdDocente)
SELECT C.NombreCurso, C.PrecioCurso, C.Cupo, D.IdDoc
FROM #Cursos C
JOIN (SELECT IdDoc, ROW_NUMBER() OVER (ORDER BY NEWID()) AS Rownum 
FROM Docente) D
ON C.IdCurso = D.Rownum;

-- 6 - Eliminar tablas temporales después de la ejecución
DROP TABLE #IdDocenteTemporal;
DROP TABLE #Cursos;

-- 7 - Repetir todo el procedimiento para poder insertar los cursos
-- que faltan 
INSERT INTO #Cursos (NombreCurso, PrecioCurso, Cupo)
VALUES
('Algebra II', 2582, 1),
('Inglés Básico', 3751, 9),
('Ingles medio', 3752, 11),
('Ingles avanzado', 3753, 4);

Select * from curso

