Create Table Roles
(
	IdRol int Identity(1,1),
	Descripcion varchar(30)
	Constraint PK_Roles Primary Key (IdRol),
);
Create Table Usuario
(
	IdUsuario int Identity(1,1),
	NombreUsuario varchar(20) not null unique,
	ClaveUsuario varchar(30) not null,
	IdRol int not null,
	Activo bit default 1,
	Constraint PK_Usuario Primary Key (IdUsuario),
	Constraint FK_Usuario_Roles Foreign Key(IdRol) References Roles(IdRol) 
);

Insert into Roles (Descripcion)values
('Administrador'),
('Empleado');

Insert Into Usuario (NombreUsuario, ClaveUsuario, IdRol, Activo) Values
('admin', 'admin25', 1, 1),
('Sara', 'sara2025', 2, 1),
('Mitri', 'Oli77', 2, 1),
('Ema', '2014', 2, 0);

Select * from Roles;
Select * from Usuario;


