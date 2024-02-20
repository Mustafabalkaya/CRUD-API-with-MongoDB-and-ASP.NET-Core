
# API CRUD con MongoDB y ASP.NET Core

Este proyecto es una API CRUD desarrollada con MongoDB y ASP.NET Core. Permite realizar operaciones básicas de creación, lectura, actualización y eliminación de productos. La API está diseñada siguiendo las mejores prácticas de desarrollo web y utiliza tecnologías modernas para ofrecer un rendimiento óptimo y una experiencia de usuario fluida.
## Tech Stack

- **ASP.NET Core**
- **MongoDB**
- **C#**

La arquitectura del proyecto sigue el patrón MVC (Modelo-Vista-Controlador), donde los controladores manejan las solicitudes HTTP, los modelos representan los datos y la lógica de negocio, y las vistas (en este caso, las respuestas JSON) se generan dinámicamente según las solicitudes.


## Archivos del Proyecto

- Controllers/ProductsController.cs: Controlador principal que maneja las solicitudes relacionadas con los productos.
- DTO/ProductDTO.cs: Objeto de transferencia de datos para representar los productos en las solicitudes HTTP.
- Models/Product.cs: Modelo que define la estructura de los productos en la base de datos MongoDB.
- Models/DatabaseSettings.cs: Clase de configuración para la conexión a la base de datos MongoDB.
- Services/ProductService.cs: Servicio que encapsula la lógica de negocio relacionada con los productos.
## Installation

- Clona este repositorio en tu máquina local.
- Asegúrate de tener instalado .NET Core SDK y MongoDB en tu sistema.
- Configura las opciones de la base de datos MongoDB en el archivo appsettings.json bajo la sección "ProductDatabase".
- Abre una terminal y navega hasta el directorio del proyecto.
- Ejecuta el comando dotnet run para compilar y ejecutar la aplicación.
- La API estará disponible en la URL especificada en la terminal (por defecto, https://localhost:5001).
    
