Create database PrestamosDB
Go
Use PrestamosDB
Go
Create table Usuarios
(
	UsuarioId int Primary Key Identity,
	Fecha date Default getdate(),
	Nombres varchar(60),
	Apellidos varchar(60),
	Cedula varchar(13) Unique,
	Email varchar(100) Unique,
	TipoUsuario int,
	NombreUsuario varchar(50) Unique,
	ClaveUsuario varchar(50) Unique,
	Activo bit Default 0
);
Go
Create table Cobradores
(
	CobradorId int Primary Key Identity,
	UsuarioId int Constraint FK_UsuarioId_Cobradores Foreign Key (UsuarioId) References Usuarios(UsuarioId) On Delete Cascade On Update Cascade,
	Fecha date Default getdate(),
	Nombres varchar(60),
	Apellidos varchar(60),
	Cedula varchar(13),
	Email varchar(100) Unique,
	Telefono varchar(13),
	Direccion varchar(100),
	Activo bit Default 0
);
Go
Create table Clientes
(
	ClienteId int Primary Key Identity,
	UsuarioId int Constraint FK_UsuarioId_Clientes Foreign Key (UsuarioId) References Usuarios(UsuarioId) On Delete Cascade On Update Cascade,
	Fecha date Default getdate(),
	Nombres varchar(60),
	Apellidos varchar(60),
	Cedula varchar(13) Unique,
	Email varchar(100) Unique,
	Telefono varchar(13),
	Celular varchar(13),
	Direccion varchar(100),
	Activo bit Default 0
);
Go
Create table Prestamos
(
	PrestamoId int Primary Key Identity,
	ClienteId int Constraint FK_ClienteId Foreign Key (ClienteId) References Clientes(ClienteId) On Delete Cascade On Update Cascade,
	CobradorId int Constraint FK_CobradorId Foreign Key (CobradorId) References Cobradores(CobradorId),
	UsuarioId int Constraint FK_UsuarioId Foreign Key (UsuarioId) References Usuarios(UsuarioId),
	Fecha date Default getdate(),
	MontoPrestado decimal(9,2),
	PorcientoInteres decimal(9,2),
	Interes decimal(9,2),
	Balance decimal(9,2),
	CantidadCuotas int
);
Go
Create table PrestamosDetalles
(
	CuotaId int Primary Key Identity,
	PrestamoId int Constraint FK_PrestamoId Foreign Key (PrestamoId) References Prestamos(PrestamoId) On Delete Cascade On Update Cascade,
	Fecha date Default getdate(),
	NumeroCuota int,
	Capital decimal(9,2),
	Interes decimal(9,2),
	Balance decimal(9,2)
);
Go
Create table Cobros
(
	CobroId int Primary Key Identity,
	ClienteId int Constraint FK_ClienteId_Cobros Foreign Key (ClienteId) References Clientes(ClienteId),
	PrestamoId int Constraint FK_PrestamoId_Cobros Foreign Key (PrestamoId) References Prestamos(PrestamoId) On Delete Cascade On Update Cascade,
	UsuarioId int Constraint FK_UsuarioId_Cobros Foreign Key (UsuarioId) References Usuarios(UsuarioId),
	Fecha date Default getdate(),
	NumeroCuota int,
	Monto decimal(9,2)
);
