CREATE DATABASE taller_db_1;

USE taller_db_1;

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
  CONSTRAINT UQ_Persona_telefono UNIQUE (telefono),
);

CREATE TABLE Categoria
(
  id_categoria INT NOT NULL,
  descripcion VARCHAR(50) NOT NULL,
  CONSTRAINT PK_Categoria_id PRIMARY KEY (id_categoria)
);

CREATE TABLE Perfil
(
  id_perfil INT NOT NULL,
  descripcion VARCHAR(20) NOT NULL,
  CONSTRAINT PK_Perfil_id PRIMARY KEY (id_perfil)
);

CREATE TABLE Usuario
(
  nombre_usuario VARCHAR(50) NOT NULL,
  contraseña VARCHAR(50) NOT NULL,
  id_usuario INT NOT NULL,
  id_perfil INT NOT NULL,
  CONSTRAINT PK_Usuario_id PRIMARY KEY (id_usuario),
  CONSTRAINT FK_Usuario_id_persona FOREIGN KEY (id_usuario) REFERENCES Persona(id_persona),
  CONSTRAINT FK_Usuario_id_perfil FOREIGN KEY (id_perfil) REFERENCES Perfil(id_perfil)
);

CREATE TABLE Tipo_Venta
(
  id_tipo INT NOT NULL,
  descripcion VARCHAR(50) NOT NULL,
  CONSTRAINT PK_Tipo_Venta_id PRIMARY KEY (id_tipo)
);

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
);

CREATE TABLE Cliente
(
  id_cliente INT NOT NULL,
  CONSTRAINT PK_Cliente_id PRIMARY KEY (id_cliente),
  CONSTRAINT FK_Cliente_id_persona FOREIGN KEY (id_cliente) REFERENCES Persona(id_persona)
);

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
);

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
);

-- RESTRICCIONES --
ALTER TABLE Persona ADD CONSTRAINT CK_sexo CHECK (sexo IN ('M', 'F'));
ALTER TABLE Persona ADD CONSTRAINT CK_nombre CHECK (nombre NOT LIKE '%[^A-Za-z ]%');
ALTER TABLE Persona ADD CONSTRAINT CK_apellido CHECK (apellido NOT LIKE '%[^A-Za-z ]%');
ALTER TABLE Persona ADD CONSTRAINT CK_telefono CHECK (telefono NOT LIKE '%[^0-9 +-%]');
ALTER TABLE Persona ADD CONSTRAINT CK_dni CHECK (dni < 100000000 AND dni > 999999);
ALTER TABLE Persona ADD CONSTRAINT CK_estado CHECK (estado IN ('A', 'I'));
ALTER TABLE Persona ADD CONSTRAINT DF_estado DEFAULT 'A' for estado;

ALTER TABLE Producto ADD CONSTRAINT CK_eliminado CHECK (eliminado IN ('N', 'S'));
ALTER TABLE Venta ADD CONSTRAINT DF_fecha_venta DEFAULT getdate() for fecha_venta;
ALTER TABLE Usuario ADD CONSTRAINT CK_contraseña CHECK (LEN(contraseña) >= 8);
ALTER TABLE Usuario ADD CONSTRAINT CK_nombre_usuario CHECK (nombre_usuario NOT LIKE '%[^A-Za-z ]%');


ALTER TABLE Usuario
DROP CONSTRAINT CK_contraseña;

-- LOTE DE DATOS --
INSERT INTO Categoria (id_categoria, descripcion) VALUES 
(1, 'Fundas'), (2, 'Pop Socket'), (3, 'Auriculares'), (4, 'Glass');

INSERT INTO Perfil (id_perfil, descripcion) VALUES 
(1, 'Administrador'), (2, 'Gerente'), (3, 'Empleado');

INSERT INTO Tipo_Venta (id_tipo, descripcion) VALUES 
(1, 'Contado'), (2, 'Crédito'), (3, 'Débito');

INSERT INTO Persona (nombre, apellido, estado, email, sexo, telefono, cumpleaños, dni) VALUES 
('Juan', 'Perez', 'A', 'juancitop12@gmail.com', 'M', '3794284911', '1989-12-09', 27288012), 
('Marta', 'Torres', 'A', 'martatorres0@gmail.com', 'F', '3795104298', '1994-04-17', 38583412), 
('Luciana', 'Fernandez', 'A', 'lucifernadnez@gmail.com', 'F', '3794228310', '2002-06-03', 44176144),
('Ana', 'Gómez', 'A', 'ana.gomez@example.com', 'F', '9876-543210', '1985-03-22', 23456789),
('Carlos', 'Rodríguez', 'I', 'carlos.rodriguez@example.com', 'M', '3794234505', '1980-01-15', 34567890),
('María', 'López', 'A', 'maria.lopez@example.com', 'F', '3784876615', '1992-09-01', 45678901),
('Luis', 'Martínez', 'A', 'luis.martinez@example.com', 'M', '5544332211', '1988-11-30', 56789012),
('Sofía', 'Ruiz', 'A', 'sofia.ruiz@example.com', 'F', '6655443322', '1994-04-10', 67890123),
('Miguel', 'Sánchez', 'I', 'miguel.sanchez@example.com', 'M', '7432-655443', '1991-02-17', 78901234),
('Laura', 'Torres', 'A', 'laura.torres@example.com', 'F', '+ 8776-765544', '1995-05-22', 89012345),
('Ricardo', 'García', 'A', 'ricardo.garcia@example.com', 'M', '9988776655', '1982-12-15', 90123456),
('Patricia', 'Fernández', 'A', 'patricia.fernandez@example.com', 'F', '3795334155', '1991-07-10', 10123456);

INSERT INTO Usuario (nombre_usuario, contraseña, id_usuario, id_perfil)
VALUES ('Luci', '12345678', 3, 1), ('Juan', '12345678', 1, 2), ('MartaT', '12345678', 2, 3);

INSERT INTO Producto (nombre_producto, precio_venta, precio_costo, eliminado, stock, id_categoria) VALUES 
('Funda de silicona para iPhone 12', 12.99, 7.00, 'N', 100, 1),
('Funda de cuero para Samsung Galaxy S21', 24.99, 15.50, 'N', 50, 1),
('Pop Socket diseño floral', 5.99, 2.50, 'N', 200, 2),
('Pop Socket liso negro', 4.99, 1.90, 'N', 150, 2),
('Auriculares inalámbricos Bluetooth', 29.99, 20.00, 'N', 80, 3),
('Auriculares con cable con micrófono', 9.99, 5.50, 'N', 120, 3),
('Protector de pantalla de vidrio templado', 7.99, 3.00, 'N', 180, 4),
('Protector de pantalla curvado', 10.99, 6.00, 'N', 90, 4);

INSERT INTO Cliente(id_cliente)
VALUES (4), (5), (6), (7), (8), (9), (10), (11), (12);

INSERT INTO Venta (fecha_venta, total_venta, id_usuario, id_tipo, id_cliente) VALUES 
('2023-09-01', 55.97, 1, 1, 4),  -- Venta por Juan, Contado, Cliente Ana Gómez
('2023-09-05', 86.95, 2, 2, 5),  -- Venta por Marta, Crédito, Cliente Carlos Rodríguez
('2023-09-10', 17.97, 3, 3, 6),   -- Venta por Luciana, Débito, Cliente María López
('2023-09-12', 31.97, 3, 1, 7),  -- Venta por Luciana, Contado, Cliente Luis Martínez
('2023-09-15', 44.96, 1, 3, 8),  -- Venta por Juan, Débito, Cliente Sofía Ruiz
('2023-09-20', 19.98, 3, 1, 9);   -- Venta por Luciana, Contado, Cliente Miguel Sánchez

INSERT INTO Detalle_Venta (cantidad, id_producto, subtotal, id_venta) VALUES 
(2, 1, 25.98, 1),  -- 2 Fundas de silicona para iPhone 12 en la Venta 1
(1, 5, 29.99, 1),  -- 1 Auricular inalámbrico en la Venta 1

(3, 2, 74.97, 2),  -- 3 Fundas de cuero para Samsung Galaxy S21 en la Venta 2
(2, 3, 11.98, 2),  -- 2 Pop Socket diseño floral en la Venta 2

(1, 7, 7.99, 3),   -- 1 Protector de pantalla de vidrio templado en la Venta 3
(2, 4, 9.98, 3),   -- 2 Pop Socket liso negro en la Venta 3

(1, 6, 9.99, 4),   -- 1 Auricular con cable en la Venta 4
(2, 8, 21.98, 4),  -- 2 Protectores de pantalla curvados en la Venta 4

(3, 1, 38.97, 5),  -- 3 Fundas de silicona para iPhone 12 en la Venta 5
(1, 3, 5.99, 5),   -- 1 Pop Socket diseño floral en la Venta 5

(2, 6, 19.98, 6);  -- 2 Auriculares con cable en la Venta 6


select * from Categoria
select * from Perfil
select * from Persona
select * from Producto
select * from Tipo_Venta
select * from Usuario
select * from Cliente

select * from Venta
select * from Detalle_Venta

DELETE FROM Cliente
WHERE id_cliente = 19;
DELETE FROM Persona
WHERE id_persona = 19;

SELECT * 
FROM Persona 
WHERE dni <= 10000000;

SELECT * 
FROM Persona 
WHERE estado = 'I';

DELETE FROM Detalle_Venta 
WHERE id_venta = 15;

DELETE FROM Venta 
WHERE id_venta = 14;
