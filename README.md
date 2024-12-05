PRUEBA 02 - BRUNO MASAFIERRO

Este proyecto corresponde a la Cátedra 2 para la asignatura Introducción al Desarrollo Web Móvil.

REQUERIMIENTOS 

* ASP.NET CORE 8 
* Entity Framework Core 
* Postman para probar la API 

CLONAR EL REPOSITORIO 

clona el repositorio con el siguiente comando 

git clone https://github.com/HiroshiGamma/prueba02.git 

RESTAURAR EL PROYECTO 

Después de clonar el repositorio, navega a la carpeta del proyecto y restaura los paquetes de NuGet:

cd api02 
dotnet restore 

BASE DE DATOS 

Crea un archivo .env con el siguiente texto: 

DATABASE_URL = Data Source=database.db

Ejecutar la Aplicación

Para ejecutar la aplicación, utiliza el siguiente comando:

dotnet run

Probar la API con Postman

Utiliza Postman para probar los endpoints de la API. Importa la colección llamada "prueba 02 postman.postman_collection.json", que está incluida en el proyecto, y ejecuta las solicitudes predefinidas.


