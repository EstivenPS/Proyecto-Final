Create database PrestamosDB
Go
Use PrestamosDB
Go
Create table Empresas
(
	EmpresaId int Primary Key Identity,
	Nombre varchar(50),
	Direccion varchar(100)
);
Go
Create table Usuarios
(
	UsuarioId int Primary Key Identity,
	EmpresaId int Constraint FK_EmpresaId Foreign Key (EmpresaId) References Empresas(EmpresaId) On Delete Cascade On Update Cascade,
	Fecha date Default getdate(),
	Nombres varchar(60),
	Apellidos varchar(60),
	Cedula varchar(13) Unique,
	TipoUsuario int,
	NombreUsuario varchar(50) Unique,
	ClaveUsuario varchar(50) Unique,
	Activo bit Default 0
);
Go
Create table Cobradores
(
	CobradorId int Primary Key Identity,
	EmpresaId int Constraint FK_EmpresaId_Cobradores Foreign Key (EmpresaId) References Empresas(EmpresaId) On Delete Cascade On Update Cascade,
	Fecha date Default getdate(),
	Nombres varchar(60),
	Apellidos varchar(60),
	Cedula varchar(13),
	Telefono varchar(13),
	Direccion varchar(100),
	Activo bit Default 0
);
Go
Create table Clientes
(
	ClienteId int Primary Key Identity,
	EmpresaId int Constraint FK_EmpresaId_Clientes Foreign Key (EmpresaId) References Empresas(EmpresaId) On Delete Cascade On Update Cascade,
	Fecha date Default getdate(),
	Nombres varchar(60),
	Apellidos varchar(60),
	Cedula varchar(13) Unique,
	Telefono varchar(13),
	Direccion varchar(100),
	Activo bit Default 0
);
Go
Create table Prestamos
(
	PrestamoId int Primary Key Identity,
	ClienteId int Constraint FK_ClienteId Foreign Key (ClienteId) References Clientes(ClienteId) On Delete Cascade On Update Cascade,
	CobradorId int Constraint FK_CobradorId Foreign Key (CobradorId) References Cobradores(CobradorId),
	Fecha date Default getdate(),
	MontoPrestado decimal(9,2),
	Mora decimal(9,2),
	Interes decimal(9,2),
	Balance decimal(9,2)
);
Go
Create table Cuotas
(
	CuotaId int Primary Key Identity,
	PrestamoId int Constraint FK_PrestamoId Foreign Key (PrestamoId) References Prestamos(PrestamoId) On Delete Cascade On Update Cascade,
	Fecha date Default getdate(),
	NumeroCuota int,
	Capital decimal(9,2),
	Interes decimal(9,2),
	Total decimal(9,2),
	Balance decimal(9,2)
);
Go
Create table Cobros
(
	CobroId int Primary Key Identity,
	PrestamoId int Constraint FK_PrestamoId_Cobros Foreign Key (PrestamoId) References Prestamos(PrestamoId) On Delete Cascade On Update Cascade,
	Fecha date Default getdate(),
	Monto decimal(9,2)
);
