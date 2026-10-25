// ATM Project V1

// variables
string nombreCliente = string.Empty;
string numeroCuenta = string.Empty;

bool estadoCuentaActiva = false;

decimal saldoDisponible = 25000m;
decimal montoOperacion = 0m;

int opcionMenu = 0;
int intentoAcceso = 3;

// Fin variables

// inicio sistema ditigal
Console.WriteLine("********** CAJERO AUTOMATICO DIGITAL **********");

// requiere nombre del usuario
Console.WriteLine("\nEscriba su nombre completo, por favor.");
nombreCliente = Console.ReadLine();

// mensaje para numero de cuenta
Console.WriteLine("\nIngrese su número de cuenta:");
Console.WriteLine("\tNúmeros de cuentas de prueba disponibles");

Console.WriteLine("1. '123456'"); // numero de cuenta de prueba

// muestra el numero ingresado por el usuario
Console.WriteLine($"\nNumero de cuenta ingresado: {numeroCuenta = Console.ReadLine()}");

// velidacion de errores
if (numeroCuenta != "123456")
{
    // loop para intento de acceso limitado
    while(intentoAcceso > 0 && numeroCuenta != "123456")
    {
        Console.WriteLine("** Mensaje: Número de cuenta no disponible. **");
        Console.WriteLine("Intenta nuevamente con tu número de cuenta.");

        intentoAcceso -= 1; // resta un intento para el acceso con un maximo de 3

        Console.WriteLine($"Intentos disponibles: {intentoAcceso}"); // muestra el numero de intentos disponibles
        Console.WriteLine($"\nNumero de cuenta ingresado: {numeroCuenta = Console.ReadLine()}\n"); // muestra numero de cuenta ingresado por el usuario

    }

}

if (numeroCuenta == "123456") // validacion para acceso a menu
    estadoCuentaActiva = true; // cambia a activa


if (estadoCuentaActiva) // validacion estado de cuenta
{
    // mensaje bienvenida
    Console.WriteLine($"\nBienvenido a DIGIT-BANK {nombreCliente}.");
    Console.WriteLine("\nElija una opción según sus necesidades:");
    
    // loop de opciones
    do
    {
        // menu de opciones
        Console.WriteLine("\t\n********** Menú de opciones **********\n");
        
        Console.WriteLine("1. Consulta de balance disponible.");
        Console.WriteLine("2. Depósito a cuenta.");
        Console.WriteLine("3. Retiro.");
        Console.WriteLine("4. Salir del menú.");

        Console.WriteLine("\t\n**************************************");
        // fin menu de opciones
            
            // loop mientras validacion de entrada
            while (!int.TryParse(Console.ReadLine(), out opcionMenu) && opcionMenu <=0)
            {
                // mensaje de error
                Console.WriteLine("Mensaje: Debe elegir un número del menú de opciones!");
                
                // menu de opciones
                Console.WriteLine("\t\n********** Menú de opciones **********\n");
                
                Console.WriteLine("1. Consulta de balance disponible.");
                Console.WriteLine("2. Depósito a cuenta.");
                Console.WriteLine("3. Retiro.");
                Console.WriteLine("4. Salir del menú.");

                Console.WriteLine("\t\n**************************************");
                // fin menu de opciones
            }

            // menu switch
            switch (opcionMenu)
            {   
                // consulta de saldo disponible ****************************************************************************************
                case 1:
                Console.WriteLine("1. * Solicitud de balance disponible. *");
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"- Su balance actual es $RD{saldoDisponible:N2} -"); // mensaje saldo actual
                Console.WriteLine("------------------------------------");
                break;
                
                // deposito a cuenta ****************************************************************************************************
                case 2:
                Console.WriteLine("2. ** Depósito a cuenta. **");
                Console.WriteLine("- Que monto desea depositar?");
                if (decimal.TryParse(Console.ReadLine(), out montoOperacion) && montoOperacion > 0) // lee el monto agregado
                    {
                        saldoDisponible += montoOperacion; // suma monto depositado
                        Console.WriteLine("***** Monto agregado satisfactoriamente *****");
                        Console.WriteLine($"Su nuevo balance actual es: $RD{saldoDisponible:N2}.");
                    }
                else
                    {
                        Console.WriteLine("Mensaje: Debe ingresar un monto mayor a 0!"); //mensaje de error
                    }
                break;

                // retiro desde cuenta **************************************************************************************************
                case 3:
                Console.WriteLine("3. *** Retiro. ***");
                Console.WriteLine("- Que monto desea retirar?");
                if (decimal.TryParse(Console.ReadLine(), out montoOperacion) && montoOperacion > 0) // lee el monto retirado
                    {
                        saldoDisponible -= montoOperacion; // resta monto retirado
                        Console.WriteLine($"Ha retirado: $RD{montoOperacion:N2}"); // muestra total retirado
                        Console.WriteLine($"Su nuevo balance actual es: $RD{saldoDisponible:N2}"); // muestra balance modificado
                    }
                else
                    {
                        Console.WriteLine("Debe ingresar un monto mayor a 0."); // mensaje de error
                    }
                break;
            }
            // fin del menu switch
        
    } while (opcionMenu < 4); // si es mayor, tambien saldra
}
else
{
    // mensaje de invalidacion de cuenta
    Console.WriteLine($"Lo sentimos {nombreCliente}, no se pudo validar su cuenta. Por favor, intente más tarde.");
}

// fin loop de opciones
// agradecimiento y despedida con nombre usuario
Console.WriteLine($"Gracias por utilizar nuestros servicios {nombreCliente}.");
Console.WriteLine("\t\nDIGIT-BANK 'Su seguridad es nuesto interés'");