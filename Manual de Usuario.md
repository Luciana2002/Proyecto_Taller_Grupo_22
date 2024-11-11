
# Manual de Usuario : Aplicación "MAGIC SHOP".

## 1. Introducción

Esta aplicación permite gestionar las ventas de un negocio a partir de una base de datos. 
Está orientado los empleados pertenecientes de una empresa de comercialización de accesorios para celulares.

## 2. Requisitos del Sistema

Visual Studio 2022 o superior.
.NET Framework (v4.0.30319).
Base de datos compatible (SQL Server Management Studio 20).

## 3. Instalación

* Clonar el repositorio y abrirlo en Visual Studio:

		git clone https://github.com/Luciana2002/Proyecto_Taller_Grupo_22.git

* Abrir el proyecto en Visual Studio.
* Configurar la cadena de conexión a la base de datos previamente creada en el archivo de configuración AppConfig (si es necesario).


## 4. Configuración

* Conexión a la Base de Datos
Para que la aplicación MAGIC SHOP funcione correctamente, es necesario configurar la conexión a la base de datos en Visual Studio. Seguir estos pasos para ajustar la configuración:

 * Abrir el archivo de configuración de la base de datos:

	  La cadena de conexión se encuentra en el archivo AppConfig de la aplicación.

 * Localizar la cadena de conexión:
	  En el archivo AppConfig, buscar la sección <connectionStrings> que se verá similar a esto: 
	    
    		<connectionStrings>
  			<add name="DefaultConnection" connectionString="Server=nombre_servidor;Database=nombre_base_datos;User Id=usuario;Password=contraseña;" providerName="System.Data.SqlClient" />
   		</connectionStrings>

 * Configurar la cadena de conexión:

    Reemplazar nombre_servidor, nombre_base_datos, usuario y contraseña con la información correspondiente a la base de datos.

 * Guardar y ejecutar la aplicación:

    Guardar el archivo AppConfig después de configurar la cadena de conexión.  
    Luego, ejecutar la aplicación desde Visual Studio. La aplicación debería conectarse a la base de datos configurada y estar lista para funcionar.

## 5. Guía de Uso
   
## 5.1 Formulario de Inicio de Sesión / Login

Al abrir la aplicación MAGIC SHOP, se muestra la pantalla de inicio de sesión, que incluye:

- Usuario: Caja de texto para ingresar el nombre de usuario.
- Contraseña: Caja de texto para ingresar la contraseña (oculta por seguridad).
- Botón Ingresar: Verifica las credenciales y permite acceder a la aplicación si son correctas.
- Botón Limpiar: Borra el contenido de ambos campos para facilitar un nuevo intento de ingreso.

![](https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/66cbd37746626fae8c75e9e0cdbe2b867b5128ab/Im%C3%A1genesManual/Form1.png)

## 5.2 Interfaz de Menú Principal

La interfaz (que es un formulario primario MDI) cuenta con los siguientes botones:
- Perfil
- Clientes
- Ventas
- Reportes
- Empleados
- Productos
- Backup
- Flecha para regresar al formulario Login

Estos redirigen a ventanas (formularios secundarios MDI) que se abrirán dentro de esta interfaz, permitiendo visuaizar los botones en el costado izquierdo.
Dependiendo del perfil del usuario que haya iniciado sesión, se mostrarán habilitados los botones correspondientes a sus permisos para realizar funciones específicas.

![](https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/FormPrincipal.png)

## 5.3 Usuario

La ventana muestra información del usuario que ha iniciado sesión, por medio de Textbox de sólo lectura. 
Nombre, Apellido, Sexo, E-mail, DNI, Teléfono y Cumpleaños.

![](https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/UsuarioInfo.png)

## 5.4 Clientes

La interfaz permite:
- Registrar clientes nuevos ingresando sus datos en el formulario (Nombre, Apellido, E-mail, Teléfono, Sexo, Cumpleaños, DNI).
- Limpiar campos de ser necesario.
- Visualizar y editar los datos de cualquier cliente a través de un Datagrid. Si se quiere modificar algún dato se debe presionar sobre la primera columna en la fila que desea modificar y esto hará que los datos de ese Cliente se carguen en los Textbox de arriba, así podrá editarlos más fácilmente.
- Guardar cambios.
- En el mismo Datagrid, es posible cambiar el estado de un cliente de Activo a Inactivo mediante una columna de botón (Acción).
- Existen tres botones que permiten generar una lista de todos los clientes, aquellos que se encuentran activos y los inactivos, respectivamente.

![](https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/Clientes.png)

## 5.5 Ventas

La interfaz permite registrar las ventas realizadas, pero antes se necesita proporcionar ciertos datos:
- Para poder obtener el ID del cliente o del producto se debe presionar el botón Buscar junto al Textbox correspondiente, este hará que se abra un nuevo formulario qué mostrará una lista de clientes o de productos según cual se presione.

![](https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/Venta.png)

Interfaz para Buscar el cliente y los productos:

![](https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/9d3237dc23ac2557b64fa5e49486cceeab434072/Im%C3%A1genesManual/BuscarCliente.png)
![](https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/9d3237dc23ac2557b64fa5e49486cceeab434072/Im%C3%A1genesManual/BuscarProducto.png)

- El ID del vendedor se obtiene automáticamente, esto porque se registra cual es el usuario que inició sesión.
- Debe ingresarse la cantidad de productos que se va a comprar el cliente, el subtotal se calcula automáticamente.

Si ya se proporcionaron estos datos se debe presionar el botón de agregar, esto hace que la información del producto junto con la cantidad que se desea adquirir se carguen al datagrid. Si se quiere eliminar un producto de la lista puede presionar la X en la columna eliminar.

![](https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/9d3237dc23ac2557b64fa5e49486cceeab434072/Im%C3%A1genesManual/AgregarProducto.png)

Una vez cargados los todos los productos debe elegir el método de pago y presionar el botón confirmar para registrar la venta, este a su vez actualiza el stock de el/los productos que se vendieron y limpia el datagrid para la próxima venta.

![](https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/9d3237dc23ac2557b64fa5e49486cceeab434072/Im%C3%A1genesManual/ConfirmarVenta.png)

Debajo se visualiza un segundo datagrid con un listado de las ventas realizadas, en este se puede:
- Buscar una venta específica filtrando los resultados por diferentes criterios, como ser el ID de venta, o fecha.
- Al hacer doble Click sobre la fila este abrirá un nuevo formulario que muestra todos los detalles de esa venta.
También al momento de registrarse una nueva venta este se actualiza mostrando la nueva venta realizada.

![](https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/9d3237dc23ac2557b64fa5e49486cceeab434072/Im%C3%A1genesManual/DetalleVenta.png)

## 5.6 Reportes
    
Dependiendo del tipo de usuario existirán tres diferentes formularios
   
### 5.6.1. Reporte Administrador
          
Permite generar reportes a través de nuevas ventanas, utilizando los botones correspondientes:
- Reporte de Usuarios
- Reporte de Clientes
- Reporte de Productos
- Registros de Backup realizados.
- Estos pueden visualizarse o bien imprimirse / guardarse como PDF.

![](https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/ReporteAdministrador.png)

### 5.6.2. Reporte Empleado
          
Permite generar reportes de las ventas dentro de un periodo de tiempo seleccionado. Se pueden visualizar los datos en un datagrid o bien imprimirse. 

![](https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/ReporteEmpleado.png)
  
### 5.6.3. Reporte Gerentes

Permite generar reportes de las ventas dentro de un periodo de tiempo seleccionado y por uno de estos criterios:

- Recaudación
- Productos más vendidos
- Total de ventas realizadas
    
![](https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/ReporteGerente.png)

Los reportes también pueden filtrarse por un vendedor y generar un listado de las ventas que realizó.

![](https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/BuscarEmpleado.png)
	
Es posible visualizar los datos en el datagrid o bien imprimirse.

### 5.7 Empleados

Al igual que el formulario de Clientes este permite:
- Registrar un nuevo empleado ingresando sus datos personales y el perfil al cual pertenece.
- Limpiar formularios.
- Guardar cambios, y visualizar los datos de los mismos una vez ingresados en un datagrid.
En el mismo, se podrá editar y cambiar de estado a cada empleado, de Activo a Inactivo y viceversa. 
Además, los botones permiten visualizar listados de todos los empleados, los activos e inactivos respectivamente.
	
![](https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/Empleados.png)

Ejemplo de como al seleccionar una fila se traen los datos a los Textboxs:

![](https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/9d3237dc23ac2557b64fa5e49486cceeab434072/Im%C3%A1genesManual/ModificarDatos.png)

### 5.8 Productos
     
Al igual que el formulario de Empleados y Clientes este permite:		
- Registrar un nuevo producto y seleccionar su categoría correspondiente.
- Limpiar campos.
- Guardar cambios y visualizar los datos de los productos en un Datagrid.
En el mismo, se podrá editar y cambiar de estado a cada producto, de Disponible a Eliminado y viceversa.
Además, los botones permiten visualizar listados de todos los productos, los disponibles y aquellos eliminados, respoctivamente.

![](https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/Productos.png)

### 5.9 Backup

Permite realizar un respaldo de la información de la base de datos en un archivo .bak.
- La base de datos es selecionada por defecto y se puede verificar su conexión (esto para saber si funciona).
- Se debe seleccionar la Ruta donde se va a guardar el archivo, al presionar el botón Ruta se abrirá el explorador de archivos y se podrá seleccionar la carpeta donde nos gustaría guardar.

![](https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/Backup.png)

## 6. Estructura de Datos

Tablas Principales

* Producto: Almacena la información de cada producto.
* Categoria: Clasifica los productos.
* Cliente: Contiene los datos de contacto del cliente.
* Venta: Registra cada transacción.
* Empleado: Almacena la información de los empleados.

## 7. Mantenimiento del Sistema

* Copia de Seguridad Manual:
   Se recomienda realizar un backup en la sección Backup semanalmente.

* Restauración de Datos
   Para restaurar datos, contacte al administrador para cargar la copia .bak y restaurar la base de datos.

## 8. Solución de Problemas Comunes

* Error de Conexión a la Base de Datos: 
   Verifique la cadena de conexión en AppConfig.
* Problemas de Ingreso al Sistema:
   Asegúrese de que las credenciales sean correctas. Contactar al administrador si es necesario.

## 9. Mejores Prácticas de Uso
    
 *  Actualización Regular de Datos:
    Mantenga los datos de clientes y productos actualizados.
 *  Frecuencia de Backups:
    Realice backups al menos semanalmente.

    
## 10. Licencia

Este proyecto está licenciado bajo la Licencia MIT. Para más detalles, revise el archivo [LICENSE](LICENSE).
