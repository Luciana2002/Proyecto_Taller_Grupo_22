
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

