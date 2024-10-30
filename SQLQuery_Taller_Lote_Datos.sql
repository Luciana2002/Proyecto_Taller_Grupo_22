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

INSERT INTO Perfil (id_perfil, descripcion) VALUES 
(1, 'Administrador'), (2, 'Gerente'), (3, 'Empleado');

INSERT INTO Tipo_Venta (id_tipo, descripcion) VALUES 
(1, 'Contado'), (2, 'Crédito'), (3, 'Débito');

INSERT INTO Persona (nombre, apellido, estado, email, sexo, telefono, cumpleaños, dni) VALUES 
('Luciana', 'Fernandez', 'A', 'lucifernadnez@gmail.com', 'F', '3794228310', '2002-06-03', 44176144),
('Juan', 'Perez', 'A', 'juancitop12@gmail.com', 'M', '3794284911', '1989-12-09', 27288012), 
('Marta', 'Torres', 'A', 'martatorres0@gmail.com', 'F', '3795104298', '1994-04-17', 38583412), 
('Ana', 'Gómez', 'A', 'ana.gomez@example.com', 'F', '9876-543210', '1985-03-22', 23456789),
('Carlos', 'Rodríguez', 'I', 'carlos.rodriguez@example.com', 'M', '3794234505', '1980-01-15', 34567890),
('María', 'López', 'A', 'maria.lopez@example.com', 'F', '3784876615', '1992-09-01', 45678901),
('Luis', 'Martínez', 'A', 'luis.martinez@example.com', 'M', '5544332211', '1988-11-30', 56789012),
('Sofía', 'Ruiz', 'A', 'sofia.ruiz@example.com', 'F', '6655443322', '1994-04-10', 67890123),
('Miguel', 'Sánchez', 'I', 'miguel.sanchez@example.com', 'M', '7432-655443', '1991-02-17', 78901234),
('Laura', 'Torres', 'A', 'laura.torres@example.com', 'F', '+ 8776-765544', '1995-05-22', 89012345),
('Ricardo', 'García', 'A', 'ricardo.garcia@example.com', 'M', '9988776655', '1982-12-15', 90123456),
('Patricia', 'Fernández', 'A', 'patricia.fernandez@example.com', 'F', '3795334155', '1991-07-10', 10123456),
('Javier', 'Morales', 'A', 'javier.morales@example.com', 'M', '3791234567', '1987-08-19', 12345678), 
('Claudia', 'Jiménez', 'A', 'claudia.jimenez@example.com', 'F', '3792345678', '1993-01-14', 23456789), 
('Fernando', 'Hernández', 'A', 'fernando.hernandez@example.com', 'M', '3793456789', '1980-03-10', 34567890),
('Elena', 'Castro', 'I', 'elena.castro@example.com', 'F', '3794567890', '1995-06-25', 45678901),
('Diego', 'Vásquez', 'A', 'diego.vasquez@example.com', 'M', '3795678901', '1983-11-11', 56789012),
('Camila', 'Alonso', 'A', 'camila.alonso@example.com', 'F', '3796789012', '1990-05-30', 67890123),
('Gabriel', 'Pérez', 'A', 'gabriel.perez@example.com', 'M', '3797890123', '1986-02-22', 78901234),
('Natalia', 'Salazar', 'A', 'natalia.salazar@example.com', 'F', '3798901234', '1991-04-17', 89012345),
('Pablo', 'Cruz', 'I', 'pablo.cruz@example.com', 'M', '3799012345', '1985-07-09', 90123456),
('Valentina', 'Ortega', 'A', 'valentina.ortega@example.com', 'F', '3790123456', '1994-12-01', 12345679),
('Santiago', 'Rojas', 'A', 'santiago.rojas@example.com', 'M', '3791234560', '1989-10-05', 23456790),
('Silvia', 'Mendoza', 'A', 'silvia.mendoza@example.com', 'F', '3792345671', '1981-09-15', 34567891),
('Andrés', 'González', 'A', 'andres.gonzalez@example.com', 'M', '3793456780', '1984-01-20', 12345680), 
('Lorena', 'Márquez', 'A', 'lorena.marquez@example.com', 'F', '3794567891', '1992-03-14', 23456781), 
('Mauricio', 'Cáceres', 'A', 'mauricio.caceres@example.com', 'M', '3795678902', '1988-02-09', 34567892),
('Karina', 'Pineda', 'I', 'karina.pineda@example.com', 'F', '3796789013', '1986-07-05', 45678903),
('Felipe', 'Rivas', 'A', 'felipe.rivas@example.com', 'M', '3797890124', '1982-05-27', 56789014),
('Gabriela', 'Arriaga', 'A', 'gabriela.arriaga@example.com', 'F', '3798901235', '1990-04-16', 67890125),
('Oscar', 'Bermúdez', 'A', 'oscar.bermudez@example.com', 'M', '3799012346', '1981-11-22', 78901236),
('Cynthia', 'Mora', 'A', 'cynthia.mora@example.com', 'F', '3790123457', '1993-06-30', 89012346),
('Rafael', 'Díaz', 'A', 'rafael.diaz@example.com', 'M', '3791234568', '1987-10-12', 90123457),
('Sabrina', 'Pérez', 'I', 'sabrina.perez@example.com', 'F', '3792345679', '1985-09-23', 12345681),
('Eduardo', 'Salas', 'A', 'eduardo.salas@example.com', 'M', '3793456781', '1994-12-08', 23456782),
('Mariana', 'Serrano', 'A', 'mariana.serrano@example.com', 'F', '3794567892', '1983-03-17', 34567893),
('Alberto', 'Vega', 'A', 'alberto.vega@example.com', 'M', '3794567893', '1980-01-05', 12345682), 
('Valeria', 'Hidalgo', 'A', 'valeria.hidalgo@example.com', 'F', '3795678904', '1990-02-20', 23456783), 
('Nicolás', 'Figueroa', 'A', 'nicolas.figueroa@example.com', 'M', '3796789015', '1986-03-30', 34567894),
('Carolina', 'Ríos', 'I', 'carolina.rios@example.com', 'F', '3797890126', '1989-04-15', 45678904),
('Ricardo', 'Mejía', 'A', 'ricardo.mejia@example.com', 'M', '3798901237', '1984-05-05', 56789015),
('Jessica', 'Guerra', 'A', 'jessica.guerra@example.com', 'F', '3799012348', '1991-06-10', 67890126),
('Esteban', 'Córdova', 'A', 'esteban.cordova@example.com', 'M', '3790123459', '1982-07-12', 78901237),
('Sofía', 'Ceballos', 'A', 'sofia.ceballos@example.com', 'F', '3791234569', '1995-08-25', 89012347),
('Julián', 'Valenzuela', 'I', 'julian.valenzuela@example.com', 'M', '3792345670', '1987-09-14', 90123458),
('Patricia', 'Alarcón', 'A', 'patricia.alarcon@example.com', 'F', '3793456782', '1992-10-30', 12345683),
('Diego', 'Cáceres', 'A', 'diego.caceres@example.com', 'M', '3794567894', '1985-11-01', 23456784),
('Clara', 'Hernández', 'A', 'clara.hernandez@example.com', 'F', '3795678905', '1988-12-29', 34567895),
('Rodolfo', 'Ortega', 'A', 'rodolfo.ortega@example.com', 'M', '3796789016', '1981-01-09', 45678905),
('Anabel', 'Bautista', 'A', 'anabel.bautista@example.com', 'F', '3797890127', '1990-02-17', 56789016),
('Gabriel', 'González', 'I', 'gabriel.gonzalez@example.com', 'M', '3798901238', '1984-03-18', 67890127),
('Renata', 'Castillo', 'A', 'renata.castillo@example.com', 'F', '3799012349', '1993-04-20', 78901238),
('Hugo', 'Pérez', 'A', 'hugo.perez@example.com', 'M', '3790123460', '1986-05-11', 89012348),
('Verónica', 'Maldonado', 'A', 'veronica.maldonado@example.com', 'F', '3791234570', '1989-06-23', 90123459),
('Fernando', 'Arévalo', 'I', 'fernando.arevalo@example.com', 'M', '3792345671', '1982-07-16', 12345684),
('Diana', 'Rojas', 'A', 'diana.rojas@example.com', 'F', '3793456783', '1991-08-27', 23456785),
('Oscar', 'López', 'A', 'oscar.lopez@example.com', 'M', '3794567895', '1985-09-03', 34567896),
('Natalia', 'Salinas', 'A', 'natalia.salinas@example.com', 'F', '3795678906', '1988-10-14', 45678906),
('Rafael', 'Vásquez', 'A', 'rafael.vasquez@example.com', 'M', '3796789017', '1981-11-12', 56789017),
('Camila', 'González', 'I', 'camila.gonzalez@example.com', 'F', '3797890128', '1994-12-05', 67890128),
('Felipe', 'Torres', 'A', 'felipe.torres@example.com', 'M', '3798901239', '1983-01-21', 78901239),
('Eliana', 'Reyes', 'A', 'eliana.reyes@example.com', 'F', '3799012350', '1990-02-19', 89012349),
('Sebastián', 'Jaramillo', 'A', 'sebastian.jaramillo@example.com', 'M', '3790123461', '1986-03-30', 90123460),
('Bárbara', 'Serrano', 'A', 'barbara.serrano@example.com', 'F', '3791234571', '1995-04-11', 12345685),
('Ignacio', 'Castro', 'I', 'ignacio.castro@example.com', 'M', '3792345672', '1987-05-08', 23456786),
('María', 'Cifuentes', 'A', 'maria.cifuentes@example.com', 'F', '3793456784', '1984-06-22', 34567897),
('Luis', 'Bermúdez', 'A', 'luis.bermudez@example.com', 'M', '3794567896', '1992-07-19', 45678907),
('Angélica', 'Ceballos', 'A', 'angelica.ceballos@example.com', 'F', '3795678907', '1981-08-10', 56789018),
('Cristian', 'Medina', 'I', 'cristian.medina@example.com', 'M', '3796789018', '1990-09-13', 67890129),
('Nataly', 'Córdoba', 'A', 'nataly.cordoba@example.com', 'F', '3797890129', '1988-10-24', 78901240),
('Gonzalo', 'Aldana', 'A', 'gonzalo.aldana@example.com', 'M', '3798901240', '1985-11-15', 89012350),
('Priscila', 'García', 'A', 'priscila.garcia@example.com', 'F', '3799012351', '1993-12-06', 90123461),
('Rodrigo', 'Figueroa', 'A', 'rodrigo.figueroa@example.com', 'M', '3790123462', '1980-01-17', 12345686),
('Karla', 'Alvarez', 'A', 'karla.alvarez@example.com', 'F', '3791234572', '1986-02-12', 23456787),
('Hernán', 'Bermúdez', 'I', 'hernan.bermudez@example.com', 'M', '3792345673', '1989-03-22', 34567898),
('Leticia', 'Arriaga', 'A', 'leticia.arriaga@example.com', 'F', '3793456785', '1994-04-29', 45678908),
('Ezequiel', 'Castañeda', 'A', 'ezequiel.castaneda@example.com', 'M', '3794567897', '1987-05-11', 56789019),
('Nadia', 'Salazar', 'A', 'nadia.salazar@example.com', 'F', '3795678908', '1983-06-30', 67890130),
('Ruben', 'Hernández', 'A', 'ruben.hernandez@example.com', 'M', '3796789019', '1985-07-14', 78901241),
('Alicia', 'Quintero', 'A', 'alicia.quintero@example.com', 'F', '3797890130', '1990-08-10', 89012351),
('Felipe', 'Pacheco', 'A', 'felipe.pacheco@example.com', 'M', '3798901241', '1992-09-05', 90123462),
('Marta', 'Avila', 'I', 'marta.avila@example.com', 'F', '3799012352', '1986-10-28', 12345687),
('Alfonso', 'Soto', 'A', 'alfonso.soto@example.com', 'M', '3790123463', '1981-11-22', 23456788),
('Claudia', 'Cáceres', 'A', 'claudia.caceres@example.com', 'F', '3791234573', '1995-12-15', 34567899),
('Santiago', 'Bermúdez', 'I', 'santiago.bermudez@example.com', 'M', '3792345674', '1984-01-17', 45678909),
('Tania', 'Martínez', 'A', 'tania.martinez@example.com', 'F', '3793456786', '1990-02-24', 56789020),
('Arturo', 'Romero', 'A', 'arturo.romero@example.com', 'M', '3794567898', '1986-03-05', 67890131),
('Marisol', 'Núñez', 'A', 'marisol.nunez@example.com', 'F', '3795678909', '1989-04-30', 78901242),
('Héctor', 'Ramírez', 'A', 'hector.ramirez@example.com', 'M', '3796789020', '1983-05-20', 89012352),
('Viviana', 'Cáceres', 'A', 'viviana.caceres@example.com', 'F', '3797890131', '1992-06-18', 90123463),
('Elias', 'Pérez', 'I', 'elias.perez@example.com', 'M', '3798901242', '1985-07-14', 12345688),
('Carla', 'Ramirez', 'A', 'carla.ramirez@example.com', 'F', '3799012353', '1994-08-24', 23456789);

INSERT INTO Usuario (nombre_usuario, contraseña, id_usuario, id_perfil)
VALUES ('Luci', '12345678', 1, 1), ('Juan', '12345678', 2, 2), ('Marta', '12345678', 3, 3),
('Ana', '12345678', 4, 3), ('Carlitos', '12345678', 5, 3), ('María', '12345678', 6, 3), ('Luis', '12345678', 7, 3);

INSERT INTO Producto (nombre_producto, precio_venta, precio_costo, eliminado, stock, id_categoria) VALUES 
('Funda de Silicona para iPhone', 10.99, 4.50, 'N', 150, 1),
('Pop Socket Estilo Mandala', 3.99, 1.20, 'N', 200, 2),
('Auriculares Bluetooth Deportivos', 25.99, 15.00, 'N', 50, 3),
('Protector de Pantalla Vidrio Templado', 5.99, 2.00, 'N', 300, 4),
('Cargador Rápido USB-C', 12.99, 6.00, 'N', 100, 5),
('Protector de Privacidad para iPhone', 14.99, 8.00, 'N', 75, 6),
('Kit de Limpieza para Pantallas', 8.99, 3.50, 'N', 120, 7),
('Estuche Organizador para Cables', 9.99, 4.00, 'N', 90, 8),
('Luz Selfie Portátil LED', 15.99, 7.00, 'N', 60, 9),
('Cámara de Seguridad WiFi', 55.99, 30.00, 'N', 40, 10),
('Adaptador USB-C a HDMI', 18.99, 10.00, 'N', 80, 11),
('Soporte para Tablet', 13.99, 6.50, 'N', 100, 12),
('Lente Gran Angular para Celulares', 22.99, 12.00, 'N', 65, 13),
('Trípode para Selfie', 12.99, 5.50, 'N', 85, 14),
('Funda para Tablet Samsung', 16.99, 8.00, 'N', 70, 15),
('Ventilador USB Portátil', 6.99, 3.00, 'N', 130, 16),
('Control para Juegos Bluetooth', 29.99, 15.00, 'N', 55, 17),
('Mini Proyector Portátil', 65.99, 35.00, 'N', 30, 18),
('Funda de Silicona para Smartwatch', 8.99, 4.00, 'N', 95, 19),
('Funda de TPU para Samsung Galaxy', 11.99, 5.00, 'N', 140, 1),
('Pop Socket Colorido', 4.99, 1.50, 'N', 230, 2),
('Auriculares con Cancelación de Ruido', 30.99, 18.00, 'N', 45, 3),
('Protector de Pantalla HD', 6.99, 2.50, 'N', 320, 4),
('Cargador Inalámbrico Rápido', 19.99, 10.00, 'N', 110, 5),
('Filtro de Privacidad para Laptop', 20.99, 11.00, 'N', 60, 6),
('Kit de Limpieza Antibacterial', 7.99, 3.00, 'N', 100, 7),
('Organizador de Escritorio', 10.99, 4.50, 'N', 95, 8),
('Luz para Selfie de 3 Niveles', 17.99, 8.50, 'N', 65, 9),
('Cámara de Vigilancia HD', 60.99, 35.00, 'N', 35, 10),
('Adaptador HDMI a VGA', 16.99, 9.00, 'N', 85, 11),
('Soporte Ajustable para Teléfono', 12.99, 5.50, 'N', 115, 12),
('Lente Macro para Celulares', 25.99, 13.00, 'N', 70, 13),
('Trípode Flexible para Selfies', 14.99, 6.00, 'N', 75, 14),
('Funda para iPad Mini', 18.99, 9.00, 'N', 80, 15),
('Mini Ventilador USB', 5.99, 2.50, 'N', 150, 16),
('Control de Juegos Inalámbrico', 35.99, 20.00, 'N', 40, 17),
('Proyector Portátil de Alta Definición', 75.99, 40.00, 'N', 25, 18),
('Funda Protectora para Smartwatch', 9.99, 4.50, 'N', 90, 19),
('Funda de Piel para iPhone', 13.99, 6.00, 'N', 125, 1),
('Pop Socket Personalizado', 5.99, 2.00, 'N', 220, 2),
('Auriculares con Bluetooth 5.0', 29.99, 16.00, 'N', 50, 3),
('Protector de Pantalla Anti-Reflejo', 7.99, 3.00, 'N', 290, 4),
('Cargador Solar Portátil', 25.99, 14.00, 'N', 55, 5),
('Protector de Privacidad para Tablet', 17.99, 9.00, 'N', 65, 6),
('Kit de Limpieza Completo', 9.99, 4.00, 'N', 105, 7),
('Caja Organizadora de Accesorios', 12.99, 5.50, 'N', 85, 8),
('Anillo de Luz para Selfies', 20.99, 11.00, 'N', 55, 9),
('Cámara IP para Exteriores', 90.99, 45.00, 'N', 30, 10),
('Adaptador USB para HDMI', 15.99, 7.50, 'N', 95, 11),
('Soporte de Coche para Teléfono', 14.99, 6.50, 'N', 110, 12),
('Lente de Telefoto para Móviles', 27.99, 15.00, 'N', 60, 13),
('Palo Selfie con Bluetooth', 10.99, 5.00, 'N', 95, 14),
('Funda para Tablet Lenovo', 19.99, 10.00, 'N', 65, 15),
('Ventilador de Escritorio USB', 7.99, 3.50, 'N', 140, 16),
('Joystick para Celular', 26.99, 14.00, 'N', 45, 17),
('Mini Proyector LED', 68.99, 38.00, 'N', 35, 18),
('Funda de Protección para Smartwatch', 8.99, 4.50, 'N', 85, 19),
('Funda de Cuero para Samsung', 12.99, 6.00, 'N', 120, 1),
('Pop Socket con Luces LED', 6.99, 3.00, 'N', 210, 2),
('Auriculares In-Ear con Micrófono', 22.99, 11.00, 'N', 55, 3),
('Protector de Pantalla UV', 8.99, 3.50, 'N', 275, 4),
('Cargador USB-C a Lightning', 14.99, 7.00, 'N', 95, 5),
('Protector de Privacidad para MacBook', 19.99, 9.50, 'N', 50, 6),
('Kit de Limpieza Portátil', 8.99, 3.50, 'N', 125, 7),
('Bolsa Organizadora de Cables', 10.99, 4.50, 'N', 90, 8),
('Luz de Relleno para Selfies', 16.99, 7.50, 'N', 70, 9),
('Cámara de Seguridad Full HD', 78.99, 41.00, 'N', 20, 10),
('Adaptador USB-C a USB 3.0', 9.99, 4.00, 'N', 100, 11),
('Soporte Magnético para Celular', 15.99, 8.00, 'N', 80, 12),
('Lente Ojo de Pez para Móviles', 24.99, 12.50, 'N', 55, 13),
('Palo Selfie Extensible', 11.99, 5.50, 'N', 105, 14),
('Funda para iPad Pro', 20.99, 10.50, 'N', 60, 15),
('Mini Ventilador con Clip', 6.99, 3.20, 'N', 130, 16),
('Control de Juegos para Android', 28.99, 15.00, 'N', 50, 17),
('Proyector Full HD Portátil', 85.99, 45.00, 'N', 20, 18),
('Funda Protectora Transparente para Smartwatch', 7.99, 3.80, 'N', 100, 19);

INSERT INTO Cliente (id_cliente)
SELECT id_persona
FROM Persona
WHERE id_persona NOT IN (SELECT id_usuario FROM Usuario);

INSERT INTO Venta (fecha_venta, total_venta, id_usuario, id_tipo, id_cliente) VALUES 
('2023-01-05', 59.94, 7, 1, 23),
('2023-02-10', 73.93, 4, 2, 3),
('2023-03-15', 91.96, 3, 1, 4),
('2023-04-20', 116.94, 4, 3, 5),
('2023-05-25', 97.94, 5, 1, 6),
('2023-06-30', 122.91, 6, 2, 7),
('2023-07-04', 123.95, 3, 3, 1),
('2023-08-12', 109.93, 7, 1, 4),
('2023-09-19', 67.96, 3, 2, 6),
('2023-10-23', 42.95, 3, 3, 2),
('2023-11-30', 73.96, 4, 1, 7),
('2023-12-15', 97.96, 5, 2, 5),
('2024-01-10', 96.95, 6, 3, 3),
('2024-02-20', 55.96, 7, 1, 2),
('2024-03-25', 45.96, 3, 2, 1),
('2024-04-05', 88.93, 4, 1, 8),
('2024-04-10', 56.95, 3, 2, 9),
('2024-04-15', 103.92, 4, 3, 10),
('2024-04-20', 65.96, 5, 1, 11),
('2024-05-01', 124.91, 6, 2, 12),
('2024-05-10', 72.94, 7, 3, 13),
('2024-05-20', 115.93, 7, 1, 14),
('2024-06-01', 92.93, 5, 2, 15),
('2024-06-10', 105.96, 3, 3, 16),
('2024-06-20', 47.95, 4, 1, 17),
('2024-07-01', 76.94, 5, 2, 18),
('2024-07-10', 133.91, 6, 3, 19),
('2024-07-15', 97.95, 7, 1, 20),
('2024-07-20', 63.95, 3, 2, 8),
('2024-08-01', 58.96, 6, 3, 9),
('2024-08-10', 119.93, 3, 1, 10),
('2024-08-15', 45.96, 4, 2, 11),
('2024-08-20', 89.92, 5, 3, 12),
('2024-08-25', 66.94, 6, 1, 13),
('2024-09-01', 82.96, 7, 2, 14);

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
(2, 6, 29.98, 15)

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