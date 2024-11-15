-------------------------------------------
---------- CREACIÓN BASE DEDATOS ----------
-------------------------------------------

CREATE DATABASE taller_db_1;
go

USE taller_db_1;
go

----------------------------------------
---------- CREACIÓN DE TABLAS ----------
----------------------------------------

if object_id('Detalle_Venta') is not null DROP TABLE Detalle_Venta;
go
---------------------
if object_id('Venta') is not null DROP TABLE Venta;
go
---------------------
if object_id('Cliente') is not null DROP TABLE Cliente;
go
---------------------
if object_id('Producto') is not null DROP TABLE Producto;
go
---------------------
if object_id('Tipo_Venta') is not null DROP TABLE Tipo_Venta;
go
---------------------
if object_id('Usuario') is not null DROP TABLE Usuario;
go
---------------------
if object_id('Perfil') is not null DROP TABLE Perfil;
go
---------------------
if object_id('Categoria') is not null DROP TABLE Categoria;
go
---------------------
if object_id('Persona') is not null DROP TABLE Persona;
go
---------------------
if object_id('Backup_Registro') is not null DROP TABLE Backup_Registro;
go
---------------------

CREATE TABLE Persona
(
  id_persona INT IDENTITY(1,1),
  nombre VARCHAR(50) NOT NULL,
  apellido VARCHAR(50) NOT NULL,
  estado VARCHAR(11) NOT NULL,
  email VARCHAR(50) NOT NULL,
  sexo VARCHAR(11) NOT NULL,
  telefono VARCHAR(30) NOT NULL,
  cumpleaños DATE NOT NULL,
  dni INT NOT NULL,
  CONSTRAINT PK_Persona_id PRIMARY KEY (id_persona),
  CONSTRAINT UQ_Persona_email UNIQUE (email),
  CONSTRAINT UQ_Persona_dni UNIQUE (dni),
  CONSTRAINT UQ_Persona_telefono UNIQUE (telefono)
)
go

CREATE TABLE Categoria
(
  id_categoria INT NOT NULL,
  descripcion VARCHAR(50) NOT NULL,
  CONSTRAINT PK_Categoria_id PRIMARY KEY (id_categoria)
)
go

CREATE TABLE Perfil
(
  id_perfil INT NOT NULL,
  descripcion VARCHAR(20) NOT NULL,
  CONSTRAINT PK_Perfil_id PRIMARY KEY (id_perfil)
)
go

CREATE TABLE Usuario
(
  nombre_usuario VARCHAR(50) NOT NULL,
  contraseña VARCHAR(50) NOT NULL,
  id_usuario INT NOT NULL,
  id_perfil INT NOT NULL,
  CONSTRAINT PK_Usuario_id PRIMARY KEY (id_usuario),
  CONSTRAINT FK_Usuario_id_persona FOREIGN KEY (id_usuario) REFERENCES Persona(id_persona),
  CONSTRAINT FK_Usuario_id_perfil FOREIGN KEY (id_perfil) REFERENCES Perfil(id_perfil)
)
go

CREATE TABLE Tipo_Venta
(
  id_tipo INT NOT NULL,
  descripcion VARCHAR(50) NOT NULL,
  CONSTRAINT PK_Tipo_Venta_id PRIMARY KEY (id_tipo)
)
go

CREATE TABLE Producto
(
  id_producto INT IDENTITY(1,1),
  nombre_producto VARCHAR(50) NOT NULL,
  precio_venta FLOAT NOT NULL,
  precio_costo FLOAT NOT NULL,
  eliminado VARCHAR(2) NOT NULL,
  stock INT NOT NULL,
  id_categoria INT NOT NULL,
  CONSTRAINT PK_Producto_id PRIMARY KEY (id_producto),
  CONSTRAINT FK_Producto_id_categoria FOREIGN KEY (id_categoria) REFERENCES Categoria(id_categoria),
  CONSTRAINT UQ_Producto_nombre UNIQUE (nombre_producto)
)
go

CREATE TABLE Cliente
(
  id_cliente INT NOT NULL,
  CONSTRAINT PK_Cliente_id PRIMARY KEY (id_cliente),
  CONSTRAINT FK_Cliente_id_persona FOREIGN KEY (id_cliente) REFERENCES Persona(id_persona)
)
go

CREATE TABLE Venta
(
  id_venta INT IDENTITY(1,1),
  fecha_venta DATE NOT NULL,
  total_venta FLOAT NOT NULL,
  id_usuario INT NOT NULL,
  id_tipo INT NOT NULL,
  id_cliente INT NOT NULL,
  CONSTRAINT PK_Venta_id PRIMARY KEY (id_venta),
  CONSTRAINT FK_Venta_id_usuario FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario),
  CONSTRAINT FK_Venta_id_tipo FOREIGN KEY (id_tipo) REFERENCES Tipo_Venta(id_tipo),
  CONSTRAINT FK_Venta_id_cliente FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente),
)
go

CREATE TABLE Detalle_Venta
(
  id_detalle INT IDENTITY(1,1),
  cantidad INT NOT NULL,
  id_producto INT NOT NULL,
  subtotal FLOAT NOT NULL,
  id_venta INT NOT NULL,
  CONSTRAINT PK_Detalle_Venta_id PRIMARY KEY (id_detalle),
  CONSTRAINT FK_Detalle_Venta_id_producto FOREIGN KEY (id_producto) REFERENCES Producto(id_producto),
  CONSTRAINT FK_Detalle_Venta_id_venta FOREIGN KEY (id_venta) REFERENCES Venta(id_venta)
)
go

CREATE TABLE Backup_Registro
(
  id_backup INT IDENTITY(1,1) PRIMARY KEY,
  fecha_backup DATETIME NOT NULL DEFAULT GETDATE(),
  id_usuario INT NOT NULL,
  ruta_backup VARCHAR(255) NOT NULL,
  CONSTRAINT FK_Backup_Registro_id_usuario FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario)
)
go

-----------------------------------
---------- RESTRICCIONES ----------
-----------------------------------

ALTER TABLE Persona ADD CONSTRAINT CK_sexo CHECK (sexo IN ('M', 'F'));
ALTER TABLE Persona ADD CONSTRAINT CK_nombre CHECK (nombre NOT LIKE '%[^A-Za-z ]%');
ALTER TABLE Persona ADD CONSTRAINT CK_apellido CHECK (apellido NOT LIKE '%[^A-Za-z ]%');
ALTER TABLE Persona ADD CONSTRAINT CK_telefono CHECK (telefono NOT LIKE '%[^0-9 +-%]');
ALTER TABLE Persona ADD CONSTRAINT CK_dni CHECK (dni < 100000000 AND dni > 999999);
ALTER TABLE Persona ADD CONSTRAINT CK_estado CHECK (estado IN ('A', 'I'));
ALTER TABLE Persona ADD CONSTRAINT DF_estado DEFAULT 'A' for estado;

ALTER TABLE Producto ADD CONSTRAINT CK_eliminado CHECK (eliminado IN ('N', 'S'));
ALTER TABLE Producto ADD CONSTRAINT DF_eliminado DEFAULT 'N' for eliminado;

ALTER TABLE Venta ADD CONSTRAINT DF_fecha_venta DEFAULT getdate() for fecha_venta;

ALTER TABLE Usuario ADD CONSTRAINT CK_contraseña CHECK (LEN(contraseña) >= 8);
ALTER TABLE Usuario ADD CONSTRAINT CK_nombre_usuario CHECK (nombre_usuario NOT LIKE '%[^A-Za-z ]%');
