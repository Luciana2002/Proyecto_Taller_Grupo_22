-----------------------------------
---------- LOTE DE DATOS ----------
-----------------------------------

INSERT INTO Categoria (id_categoria, descripcion) VALUES 
(1, 'Fundas y Protectores'), 
(2, 'Pop Socket'), 
(3, 'Auriculares y Altavoces'), 
(4, 'Protectores de Pantalla'), 
(5, 'Cargadores y Baterías'), 
(6, 'Protectores de Privacidad'), 
(7, 'Kits de Limpieza'), 
(8, 'Estuches y Organizadores'), 
(9, 'Luces y Accesorios para Selfies'), 
(10, 'Cámaras de Seguridad'), 
(11, 'Adaptadores'), 
(12, 'Soportes'), 
(13, 'Lentes para Celulares'), 
(14, 'Accesorios para Selfies'), 
(15, 'Fundas para Tablets'), 
(16, 'Ventiladores USB'), 
(17, 'Controles para Juegos'), 
(18, 'Proyectores Portátiles'), 
(19, 'Fundas para Smartwatches');

-- select * from Categoria

INSERT INTO Perfil (id_perfil, descripcion) VALUES 
(1, 'Administrador'), (2, 'Gerente'), (3, 'Empleado');

-- select * from Perfil

INSERT INTO Tipo_Venta (id_tipo, descripcion) VALUES 
(1, 'Contado'), (2, 'Crédito'), (3, 'Débito');

-- select * from Tipo_Venta

INSERT INTO Persona (nombre, apellido, estado, email, sexo, telefono, cumpleaños, dni) VALUES 
('Luciana', 'Fernandez', 'A', 'lucifernadnez@gmail.com', 'F', '3794228310', '2002-06-03', 44176144),
('Juan', 'Perez', 'A', 'juancitop12@gmail.com', 'M', '3794284911', '1989-12-09', 27288012), 
('Marta', 'Torres', 'A', 'martatorres0@gmail.com', 'F', '3795104298', '1994-04-17', 38583412), 
('Ana', 'Gómez', 'A', 'ana.gomez@example.com', 'F', '9876-543210', '1985-03-22', 23456721),
('Carlos', 'Rodríguez', 'I', 'carlos.rodriguez@example.com', 'M', '3794234505', '1980-01-15', 34567890),
('María', 'López', 'A', 'maria.lopez@example.com', 'F', '3784876615', '1992-09-01', 45678901),
('Luis', 'Martínez', 'A', 'luis.martinez@example.com', 'M', '5544332211', '1988-11-30', 56784112),
('Sofía', 'Ruiz', 'A', 'sofia.ruiz@example.com', 'F', '6655443322', '1994-04-10', 65440123),
('Miguel', 'Sánchez', 'I', 'miguel.sanchez@example.com', 'M', '7432-655443', '1991-02-17', 78901234),
('Laura', 'Torres', 'A', 'laura.torres@example.com', 'F', '+ 8776-765544', '1995-05-22', 89012345),
('Ricardo', 'García', 'A', 'ricardo.garcia@example.com', 'M', '9988776655', '1982-12-15', 90123456),
('Patricia', 'Fernández', 'A', 'patricia.fernandez@example.com', 'F', '3795334155', '1991-07-10', 10123456),
('Javier', 'Morales', 'A', 'javier.morales@example.com', 'M', '3791234567', '1987-08-19', 12345678), 
('Claudia', 'Jiménez', 'A', 'claudia.jimenez@example.com', 'F', '3792345678', '1993-01-14', 23456789), 
('Fernando', 'Hernández', 'A', 'fernando.hernandez@example.com', 'M', '3793456789', '1980-03-10', 34505890),
('Elena', 'Castro', 'I', 'elena.castro@example.com', 'F', '3794567890', '1995-06-25', 45678943),
('Diego', 'Vásquez', 'A', 'diego.vasquez@example.com', 'M', '3795678901', '1983-11-11', 56789012),
('Camila', 'Alonso', 'A', 'camila.alonso@example.com', 'F', '3796789012', '1990-05-30', 67890123),
('Gabriel', 'Pérez', 'A', 'gabriel.perez@example.com', 'M', '3797890123', '1986-02-22', 78901134),
('Natalia', 'Salazar', 'A', 'natalia.salazar@example.com', 'F', '3798901234', '1991-04-17', 89609845),
('Pablo', 'Cruz', 'I', 'pablo.cruz@example.com', 'M', '3799012345', '1985-07-09', 90170556),
('Valentina', 'Ortega', 'A', 'valentina.ortega@example.com', 'F', '3790123456', '1994-12-01', 19345679),
('Santiago', 'Rojas', 'A', 'santiago.rojas@example.com', 'M', '3791234560', '1989-10-05', 23456790),
('Silvia', 'Mendoza', 'A', 'silvia.mendoza@example.com', 'F', '3792345671', '1981-09-15', 34567801),
('Andrés', 'González', 'A', 'andres.gonzalez@example.com', 'M', '3793456780', '1984-01-20', 12245680), 
('Lorena', 'Márquez', 'A', 'lorena.marquez@example.com', 'F', '3794567891', '1992-03-14', 23426781), 
('Mauricio', 'Cáceres', 'A', 'mauricio.caceres@example.com', 'M', '3795678902', '1988-02-09', 34567592),
('Karina', 'Pineda', 'I', 'karina.pineda@example.com', 'F', '3796789013', '1986-07-05', 45278903),
('Felipe', 'Rivas', 'A', 'felipe.rivas@example.com', 'M', '3797890124', '1982-05-27', 56789014),
('Gabriela', 'Arriaga', 'A', 'gabriela.arriaga@example.com', 'F', '3798901235', '1990-04-16', 67890125);

-- select * from Persona

INSERT INTO Usuario (nombre_usuario, contraseña, id_usuario, id_perfil) VALUES 
('Luci', '12345678', 1, 1), ('Juan', '12345678', 2, 2), ('Marta', '12345678', 3, 2),
('Ana', '12345678', 4, 3), ('Carlitos', '12345678', 5, 3), ('María', '12345678', 6, 3), ('Luis', '12345678', 7, 3);

-- select * from Usuario

INSERT INTO Producto (nombre_producto, precio_venta, precio_costo, eliminado, stock, id_categoria) VALUES 
('Funda de Silicona para iPhone', 10.99, 4.50, 'N', 150, 1),
('Pop Socket Estilo Mandala', 3.99, 1.20, 'N', 20, 2),
('Auriculares Bluetooth Deportivos', 25.99, 15.00, 'N', 50, 3),
('Protector de Pantalla Vidrio Templado', 5.99, 2.00, 'N', 38, 4),
('Cargador Rápido USB-C', 12.99, 6.00, 'N', 10, 5),
('Protector de Privacidad para iPhone', 14.99, 8.00, 'N', 75, 6),
('Kit de Limpieza para Pantallas', 8.99, 3.50, 'N', 3, 7),
('Estuche Organizador para Cables', 9.99, 4.00, 'N', 90, 8),
('Luz Selfie Portátil LED', 15.99, 7.00, 'N', 60, 9),
('Cámara de Seguridad WiFi', 55.99, 30.00, 'N', 40, 10),
('Adaptador USB-C a HDMI', 18.99, 10.00, 'N', 80, 11),
('Soporte para Tablet', 13.99, 6.50, 'N', 70, 12),
('Lente Gran Angular para Celulares', 22.99, 12.00, 'N', 65, 13),
('Trípode para Selfie', 12.99, 5.50, 'N', 85, 14),
('Funda para Tablet Samsung', 16.99, 8.00, 'N', 70, 15),
('Ventilador USB Portátil', 6.99, 3.00, 'N', 130, 16),
('Control para Juegos Bluetooth', 29.99, 15.00, 'N', 55, 17),
('Mini Proyector Portátil', 65.99, 35.00, 'N', 30, 18),
('Funda de Silicona para Smartwatch', 8.99, 4.00, 'N', 95, 19),
('Funda de TPU para Samsung Galaxy', 11.99, 5.00, 'S', 0, 1),
('Pop Socket Colorido', 4.99, 1.50, 'N', 230, 2),
('Auriculares con Cancelación de Ruido', 30.99, 18.00, 'N', 45, 3),
('Protector de Pantalla HD', 6.99, 2.50, 'N', 320, 4),
('Cargador Inalámbrico Rápido', 19.99, 10.00, 'N', 110, 5),
('Filtro de Privacidad para Laptop', 20.99, 11.00, 'N', 60, 6),
('Kit de Limpieza Antibacterial', 7.99, 3.00, 'N', 100, 7),
('Organizador de Escritorio', 10.99, 4.50, 'S', 0, 8),
('Luz para Selfie de 3 Niveles', 17.99, 8.50, 'N', 65, 9),
('Cámara de Vigilancia HD', 60.99, 35.00, 'N', 35, 10),
('Adaptador HDMI a VGA', 16.99, 9.00, 'S', 0, 11);

-- select * from Producto

INSERT INTO Cliente (id_cliente)
SELECT id_persona
FROM Persona
WHERE id_persona NOT IN (SELECT id_usuario FROM Usuario);

-- select * from Cliente

INSERT INTO Venta (fecha_venta, total_venta, id_usuario, id_tipo, id_cliente) VALUES 
('2023-01-05', 59.94, 7, 1, 23),
('2023-02-10', 73.93, 4, 2, 11),
('2023-03-15', 91.96, 6, 1, 29),
('2023-04-20', 116.94, 4, 3, 12),
('2023-05-25', 97.94, 5, 1, 20),
('2023-06-30', 122.91, 6, 2, 9),
('2023-07-04', 123.95, 4, 3, 12),
('2023-08-12', 109.93, 7, 1, 17),
('2023-09-19', 67.96, 4, 2, 8),
('2023-10-23', 42.95, 6, 3, 25),
('2023-11-30', 73.96, 4, 1, 15),
('2023-12-15', 97.96, 5, 2, 22),
('2024-01-10', 96.95, 6, 3, 28),
('2024-02-20', 55.96, 7, 1, 17),
('2024-03-25', 45.96, 7, 2, 26),
('2024-04-05', 88.93, 4, 1, 8),
('2024-04-10', 56.95, 6, 2, 21),
('2024-04-15', 103.92, 4, 3, 19),
('2024-04-20', 65.96, 5, 1, 14),
('2024-05-01', 124.91, 6, 2, 13),
('2024-05-10', 72.94, 7, 3, 27),
('2024-05-20', 115.93, 7, 1, 15),
('2024-06-01', 92.93, 5, 2, 10),
('2024-06-10', 105.96, 4, 3, 20),
('2024-06-20', 47.95, 4, 1, 11),
('2024-07-01', 76.94, 5, 2, 18),
('2024-07-10', 133.91, 6, 3, 29),
('2024-07-15', 97.95, 7, 1, 16),
('2024-07-20', 63.95, 4, 2, 24),
('2024-08-01', 58.96, 6, 3, 9),
('2024-08-10', 119.93, 7, 1, 12),
('2024-08-15', 45.96, 4, 2, 25),
('2024-08-20', 89.92, 5, 3, 23),
('2024-08-25', 66.94, 6, 1, 30),
('2024-09-01', 82.96, 7, 2, 14);

-- select * from Venta

INSERT INTO Detalle_Venta (cantidad, id_producto, subtotal, id_venta) VALUES 
-- Para la Venta 1
(2, 1, 21.98, 1),
(3, 2, 11.97, 1),
(1, 3, 25.99, 1),

-- Para la Venta 2
(1, 4, 5.99, 2),
(2, 5, 25.98, 2),
(1, 6, 14.99, 2),
(3, 7, 26.97, 2),

-- Para la Venta 3
(2, 8, 19.98, 3),
(1, 9, 15.99, 3),
(1, 10, 55.99, 3),

-- Para la Venta 4
(3, 11, 56.97, 4),
(1, 12, 13.99, 4),
(2, 13, 45.98, 4),

-- Para la Venta 5
(1, 14, 12.99, 5),
(2, 15, 33.98, 5),
(3, 16, 50.97, 5),

-- Para la Venta 6
(1, 1, 10.99, 6),
(1, 3, 25.99, 6),
(2, 5, 25.98, 6),
(1, 7, 8.99, 6),
(3, 8, 50.96, 6),

-- Para la Venta 7
(2, 2, 7.98, 7),
(1, 4, 5.99, 7),
(2, 10, 109.98, 7),

-- Para la Venta 8
(2, 5, 25.98, 8),
(1, 9, 15.99, 8),
(1, 11, 18.99, 8),
(3, 14, 38.97, 8),

-- Para la Venta 9
(1, 15, 16.99, 9),
(2, 12, 27.98, 9),
(1, 13, 22.99, 9),

-- Para la Venta 10
(3, 1, 32.97, 10),
(1, 2, 3.99, 10),
(1, 4, 5.99, 10),

-- Para la Venta 11
(2, 3, 51.98, 11),
(1, 5, 12.99, 11),
(1, 7, 8.99, 11),

-- Para la Venta 12
(1, 9, 15.99, 12),
(1, 10, 55.99, 12),
(2, 14, 25.98, 12),

-- Para la Venta 13
(2, 13, 45.98, 13),
(3, 15, 50.97, 13),

-- Para la Venta 14
(1, 1, 10.99, 14),
(2, 5, 25.98, 14),
(1, 11, 18.99, 14),

-- Para la Venta 15
(1, 4, 5.99, 15),
(1, 8, 9.99, 15),
(2, 6, 29.98, 15),

-- Para la Venta 16
(1, 5, 15.99, 16),
(2, 8, 39.98, 16),
(1, 10, 32.96, 16),

-- Para la Venta 17
(1, 11, 18.99, 17),
(2, 12, 27.98, 17),
(1, 13, 9.98, 17),

-- Para la Venta 18
(2, 1, 21.98, 18),
(1, 2, 3.99, 18),
(1, 4, 5.99, 18),
(3, 6, 71.96, 18),

-- Para la Venta 19
(2, 3, 51.98, 19),
(1, 7, 8.99, 19),
(2, 9, 43.98, 19),

-- Para la Venta 20
(1, 14, 12.99, 20),
(2, 11, 37.98, 20),
(3, 15, 74.97, 20),

-- Para la Venta 21
(1, 1, 10.99, 21),
(3, 2, 11.97, 21),
(2, 3, 39.98, 21),
(1, 4, 5.99, 21),

-- Para la Venta 22
(2, 6, 23.98, 22),
(1, 8, 19.99, 22),
(3, 10, 89.97, 22),

-- Para la Venta 23
(2, 9, 31.98, 23),
(1, 12, 13.99, 23),
(2, 13, 19.98, 23),

-- Para la Venta 24
(3, 14, 38.97, 24),
(2, 15, 33.98, 24),
(1, 16, 26.98, 24),

-- Para la Venta 25
(1, 5, 12.99, 25),
(2, 7, 17.98, 25),
(2, 9, 27.98, 25),

-- Para la Venta 26
(2, 2, 11.98, 26),
(1, 4, 5.99, 26),
(3, 6, 44.97, 26),

-- Para la Venta 27
(2, 3, 45.98, 27),
(1, 10, 55.99, 27),
(2, 12, 31.98, 27),

-- Para la Venta 28
(3, 11, 56.97, 28),
(2, 13, 19.98, 28),
(1, 16, 38.96, 28),

-- Para la Venta 29
(1, 1, 10.99, 29),
(2, 3, 39.98, 29),
(1, 4, 5.99, 29),

-- Para la Venta 30
(1, 5, 12.99, 30),
(2, 7, 17.98, 30),
(1, 8, 9.99, 30),

-- Para la Venta 31
(2, 9, 31.98, 31),
(3, 11, 56.97, 31),
(1, 15, 16.99, 31),

-- Para la Venta 32
(1, 2, 5.99, 32),
(2, 4, 7.98, 32),
(1, 6, 25.99, 32),

-- Para la Venta 33
(1, 8, 19.99, 33),
(2, 9, 35.98, 33),
(1, 10, 43.96, 33),

-- Para la Venta 34
(3, 13, 29.97, 34),
(1, 12, 14.99, 34),
(1, 16, 38.96, 34),

-- Para la Venta 35
(2, 5, 25.98, 35),
(1, 14, 12.99, 35),
(1, 11, 18.99, 35);

-- select * from Detalle_Venta

INSERT INTO Backup_Registro (fecha_backup, id_usuario, ruta_backup) VALUES 
('2023-04-12 14:25:35.384', 2, 'C:\Archivos\3er Año\Taller II\taller_db_1_20230412_142535.bak'),
('2023-08-07 10:12:48.572', 2, 'C:\Archivos\3er Año\Taller II\taller_db_1_20230807_101248.bak'),
('2023-12-01 09:03:12.195', 2, 'C:\Archivos\3er Año\Taller II\taller_db_1_20231201_090312.bak'),
('2024-01-15 17:30:25.112', 3, 'C:\Archivos\3er Año\Taller II\taller_db_1_20240115_173025.bak'),
('2024-03-18 11:45:05.950', 2, 'C:\Archivos\3er Año\Taller II\taller_db_1_20240318_114505.bak'),
('2024-05-22 13:55:32.500', 3, 'C:\Archivos\3er Año\Taller II\taller_db_1_20240522_135532.bak'),
('2024-07-10 08:15:43.294', 3, 'C:\Archivos\3er Año\Taller II\taller_db_1_20240710_081543.bak'),
('2024-08-25 19:20:10.588', 2, 'C:\Archivos\3er Año\Taller II\taller_db_1_20240825_192010.bak'),
('2024-09-12 15:10:55.831', 2, 'C:\Archivos\3er Año\Taller II\taller_db_1_20240912_151055.bak'),
('2024-10-14 07:40:18.727', 3, 'C:\Archivos\3er Año\Taller II\taller_db_1_20241014_074018.bak');

-- select * from Backup_Registro
