create database Escuela
use Escuela
GO

create table Alumno
(
IdAlumno int identity(1,1),
DNI varchar(8) unique not null,
Apellido varchar(100),
Nombre varchar(100),
Edad int,
EsRegular varchar(100),
Estado bit default 1,
Mail nvarchar(200),
primary key(IdAlumno)

)

select * from Alumno