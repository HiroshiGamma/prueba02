# IDWM 2024-2: Cátedra 2

Este proyecto corresponde a la Cátedra 2 para la asignatura Introducción al Desarrollo Web Móvil.

## Requerimientos

- **[ASP.NET Core 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)** 
- **[Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)** 
- **[Postman](https://www.postman.com/downloads/)** para probar la API

## Clonar el Repositorio

Clona el repositorio con el siguiente comando:

git clone https://github.com/HiroshiGamma/prueba02.git 

## Restaurar el Proyecto

Después de clonar el repositorio, navega a la carpeta del proyecto y restaura los paquetes de NuGet:

cd api02 
dotnet restore 

## Base de Datos

Crea un archivo .env con el siguiente texto: 

DATABASE_URL = Data Source=database.db

## Ejecutar la Aplicación

Para ejecutar la aplicación, utiliza el siguiente comando:

dotnet run

## Probar la API con Postman

Utiliza Postman para probar los endpoints de la API. Importa la colección llamada "prueba 02 postman.postman_collection.json", que está incluida en el proyecto, y ejecuta las solicitudes predefinidas.


