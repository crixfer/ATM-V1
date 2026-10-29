# Cajero Automático Digital

Aplicación de consola desarrollada en C# que simula algunas operaciones básicas de un cajero automático. Permite consultar un balance, realizar depósitos y retirar dinero de una cuenta de prueba. Es un proyecto educativo y no se conecta a servicios bancarios reales.

## Requisitos

- .NET 10 SDK

## Cómo ejecutar

Desde la raíz del repositorio, ejecuta:

```bash
dotnet run --project ATMProject/ATMProject.csproj
```

## Uso

Al iniciar, el programa solicita un número de cuenta y luego presenta un menú con estas opciones:

1. Consultar el balance disponible.
2. Depositar dinero.
3. Retirar dinero.
4. Salir del menú.

Los depósitos y retiros deben ser mayores que cero. No se permite retirar más dinero del balance disponible. El programa muestra el balance actualizado después de cada operación.

## Datos de prueba y comportamiento actual

- El balance inicial es de **RD$25,000.00**.
- El nombre del cliente está definido en el código como `Christopher Portorreal`; actualmente no se solicita por consola.
- La pantalla anuncia los números `123456` y `111222`, pero la validación del código activa la cuenta únicamente cuando se introduce `1`. Por lo tanto, los números anunciados no funcionan como identificadores de cuenta en la versión actual.
- El balance y las operaciones se conservan solo durante la ejecución. Al cerrar el programa, los cambios se pierden.

## Tecnologías

- C#
- .NET 10

## Estructura

```text
ATMProject/
├── ATMProject.csproj
└── Program.cs
```

La lógica de la aplicación está en [`ATMProject/Program.cs`](ATMProject/Program.cs) y la configuración del proyecto en [`ATMProject/ATMProject.csproj`](ATMProject/ATMProject.csproj).

## Alcance

Este proyecto sirve como práctica de programación en C#: entrada y salida por consola, validación de datos, condicionales, ciclos, métodos y operaciones con saldo. No implementa autenticación segura, persistencia de datos ni transacciones financieras reales.
