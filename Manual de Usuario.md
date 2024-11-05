
Manual de Usuario : Aplicación "MAGIC SHOP".
1. Introducción
Esta aplicación permite gestionar productos a partir de una base de datos, en un contexto de ventas presenciales. 
Está orientado a usuarios pertenecientes a una empresa de comercialización de accesorios de celulares, siendo estos: 
Administradores, Gerentes, y Empleados.

2. Requisitos del Sistema

Visual Studio 2022 o superior.
.NET Framework (especifica la versión).
Base de datos compatible (ej., SQL Server).

3. Instalación
Clonar el repositorio y abrirlo en Visual Studio:
bash
Copiar código
git clone https://github.com/Luciana2002/Proyecto_Taller_Grupo_22.git

Abrir el proyecto en Visual Studio.
Configurar la cadena de conexión a la base de datos previamente creada en el archivo de configuración AppConfig (si es necesario).


4. Configuración

Conexión a la Base de Datos
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
    Luego, ejecutar la aplicación desde Visual Studio. La aplicación debería conectarse a la base de datos configurada y estar lista para gestionar productos.

5. Guía de Uso
   
5.1 Formulario de Inicio de Sesión / Login

(https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/Form1.png)
Al abrir la aplicación MAGIC SHOP, se muestra la pantalla de inicio de sesión, que incluye:

* Usuario: Caja de texto para ingresar el nombre de usuario.
* Contraseña: Caja de texto para ingresar la contraseña (oculta por seguridad).
* Botón Ingresar: Verifica las credenciales y permite acceder a la aplicación si son correctas.
* Botón Limpiar: Borra el contenido de ambos campos para facilitar un nuevo intento de ingreso.

5.2 Interfaz de Menú Principal

(https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/FormPrincipal.png)
La interfaz (que es un formulario primario MDI) cuenta con los siguientes botones:
* Perfil
* Clientes
* Ventas
* Reportes
* Empleados
* Productos
* Backup
* Flecha para regresar al formulario Login

Estos redirigen a ventanas (formularios secundarios MDI) que se abrirán dentro de esta interfaz, permitiendo visuaizar los botones en el costado izquierdo.
Dependiendo del perfil del usuario que haya iniciado sesión, se mostrarán habilitados los botones correspondientes a sus permisos para realizar funciones específicas.

5.3 Usuario

(https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/UsuarioInfo.png)
La ventana muestra información del usuario que ha iniciado sesión, por medio de Textbox de sólo lectura. 
Nombre, Apellido, Sexo, E-mail, DNI, Teléfono y Cumpleaños.

5.4 Clientes

https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/Clientes.png
La interfaz permite:
*Registrar clientes nuevos ingresando sus datos en el formulario (Nombre, Apellido, E-mail, Teléfono, Sexo, Cumpleaños, DNI).
*Limpiar campos de ser necesario.
*Guardar cambios.
*Visualizar y editar los datos de cualquier cliente a través de un Datagrid.
*En el mismo Datagrid, es posible cambiar el estado de un cliente de Activo a Inactivo mediante una columna de botón.
*Existen tres botones que permiten generar una lista de todos los clientes, aquellos que se encuentran activos y los inactivos, respectivamente.

5.5 Ventas

https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/Venta.png
La interfaz permite:
*Registrar las ventas realizadas.
* Debe ingresarse: 
	- Los datos del vendedor (ID y Nombre),
	 -Cantidad de productos.	
	- El método de pago a utilizar (por medio de un combo box).
Se calculará el total a pagar.
*Visualizar un listado con el detalle de las ventas realizadas. Este puede filtrarse por diferentes criterios, como ser el ID de venta, o fecha.
*Se puede confirmar la venta mediante un botón.

	5.5.1. Buscar CLiente

	https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/BuscarCliente.png
    	Buscar al cliente que realizará la compra, los cuales deben encontrarse previamente registrados en la base de datos de la aplicación, 
	estos resultados se visualizan en una ventana emergente. 

  	5.5.2 Buscar Producto

	https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/BuscarProducto.png
        Permite buscar los productos según diferentes filtros, por ejemplo el ID de producto y visualizar los datos.

5.6 Reportes
    
Dependiendo del tipo de usuario existirán tres diferentes formularios:
   
5.6.1. Reporte Administrador
          
https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/ReporteAdministrador.png
          Permite generar reportes a través de nuevas ventanas, utilizando los botones correspondientes:
          *Reporte de Usuarios
          *Reporte de Clientes
          *Reporte de Productos
          *Registros de Backup realizados.
          Estos pueden visualizarse o bien imprimirse / guardarse como PDF.

5.6.2. Reporte Empleado
	  
   https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/ReporteEmpleado.png
          Permite generar reportes de las ventas dentro de un periodo de tiempo seleccionado.
          Se pueden visualizar los datos en un datagrid o bien imprimirse. 
  
5.6.3. Reporte Gerentes
  
https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/ReporteGerente.png
          Permite generar reportes de las ventas dentro de un periodo de tiempo seleccionado
          *Recaudación
          *Productos más vendidos
	  *Total de ventas realizadas
          Es posible visualizar los datos en un datagrid o bien imprimirse.
          
5.6.3.1. Buscar Empleado
	  https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/BuscarEmpleado.png
		Los reportes pueden filtrarse según vendedor y se visualiza un listado de las mismas en una nueva ventana.

5.7 Empleados
	
 https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/Empleados.png
     Permite:
	*registrar un nuevo empleado ingresando sus datos personales y el perfil al cual pertenece,
	* limpiar formularios, 
	* guardar cambios, y visualizar los datos de los mismos una vez ingresados en un datagrid.
En el mismo, se podrá editar y cambiar de estado a cada empleado, de Activo a Inactivo y viceversa. 
Además, los botones permiten visualizar listados de todos los empleados, los activos e inactivos respectivamente.

5.8 Productos
	
 https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/Productos.png
     Permite:		
	* Registrar un nuevo producto y seleccionar su categoría correspondiente,
 	*limpiar campos, 
	*Guardar cambios y visualizar los datos de los productos en un Datagrid.
En el mismo, se podrá editar y cambiar de estado a cada producto, de Disponible a Eliminado y viceversa.
Además, los botones permiten visualizar listados de todos los productos, los disponibles y aquellos eliminados, respoctivamente.

5.9 Backup
	
https://github.com/Luciana2002/Proyecto_Taller_Grupo_22/blob/master/Im%C3%A1genesManual/Backup.png
Permite realizar un respaldo de la información de la base de datos en un archivo .bak.
Se debe seleccionar la base de datos y verificar su conexión, así como la ruta donde se guardará.


