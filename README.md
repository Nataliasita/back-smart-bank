# back-smart-bank

# Backend API en .NET Core - Gestión de Pagos

Este proyecto es un backend desarrollado en .NET Core que proporciona un API REST para gestionar pagos de clientes. 

## Características

El sistema permite las siguientes operaciones:

- **GET /payments/{userId}**: Devuelve un listado de los pagos realizados por un cliente, incluyendo el estado de cada pago.
- **POST /payments**: Permite registrar un nuevo pago en el sistema.

## Requisitos Previos

Antes de ejecutar este proyecto, asegúrate de tener instalados los siguientes componentes:

- [SDK de .NET Core 6.0 o superior](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server) u otro sistema de base de datos compatible
- [Postman](https://www.postman.com/) o cualquier herramienta para probar APIs REST

## Instalación

1. Clona este repositorio en tu máquina local:
   ```bash
   git clone https://github.com/tu-usuario/tu-repositorio.git
   cd tu-repositorio

2. Restaura las dependencias del proyecto:

    dotnet restore

3. Configura la conexión a la base de datos en el archivo appsettings.json:

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=TU_SERVIDOR;Database=TU_BASE_DE_DATOS;User Id=TU_USUARIO;Password=TU_PASSWORD;"
  }
}

## Tecnologías Utilizadas

.NET Core 8.0
Entity Framework Core: ORM para la interacción con la base de datos.
MYSQL: Base de datos relacional (puede reemplazarse por otro motor compatible).
Swagger/OpenAPI: Documentación interactiva de la API.

Link acceso: https://www.postman.com/blue-firefly-747343/api-bank-smart/request/urbjq6h/listar-pagos?action=share&creator=34111815&ctx=documentation