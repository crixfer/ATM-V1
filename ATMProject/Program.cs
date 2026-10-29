// ATM Project V1

// variables
using System.ComponentModel.DataAnnotations;

string nombreCliente = "Christopher Portorreal";
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
// Console.WriteLine("\nEscriba su nombre completo, por favor.");
// nombreCliente = Console.ReadLine().ToUpper();

// mensaje para numero de cuenta
Console.WriteLine("\nElija un número de cuenta:");
Console.WriteLine("\nNúmeros de cuentas de prueba disponibles");

Console.WriteLine("1. '123456'"); // numero de cuenta activa de prueba
Console.WriteLine("2. '111222'"); // numero de cuenta inactiva de prueba

Console.Write("\nOpción: ");

// numero ingresado por el usuario
numeroCuenta = Console.ReadLine()!;

// velidacion de errores
if (numeroCuenta != "1")
{
    // loop para intento de acceso limitado
    while(intentoAcceso > 0 && numeroCuenta != "1")
    {
        Console.WriteLine("** Mensaje: Número de cuenta no disponible. **");
        Console.WriteLine("Intenta nuevamente con tu número de cuenta.");

        intentoAcceso -= 1; // resta un intento para el acceso con un maximo de 3

        Console.WriteLine($"Intentos disponibles: {intentoAcceso}"); // muestra el numero de intentos disponibles
        Console.WriteLine($"\nNumero de cuenta ingresado: {numeroCuenta = Console.ReadLine()!}\n"); // muestra numero de cuenta ingresado por el usuario

    }

}

if (numeroCuenta == "1") // validacion para acceso a menu
    estadoCuentaActiva = true; // cambia a activa

// METODOS_____________________________________________________________________________________________

void MostrarMenu() // Metodo para mostrar menu
{
    // menu de opciones
        Console.WriteLine("\t\n********** Menú de opciones **********\n");
        
        Console.WriteLine("1. Consulta de balance disponible.");
        Console.WriteLine("2. Depósito a cuenta.");
        Console.WriteLine("3. Retiro.");
        Console.WriteLine("\n4. Salir del menú.");

        Console.WriteLine("\t\n**************************************");

        Console.Write("Opción: ");
        // fin menu de opciones
}

void MostrarBalance() // Metodo para mostrar balance
{
    Console.WriteLine("------------------------------------");
    Console.WriteLine($"- Su balance actual es $RD{saldoDisponible:N2}."); // mensaje saldo actual
    Console.WriteLine("------------------------------------");
}

decimal Deposito(string mensaje) // Metodo manejo depositos y nuevo balance
{
    Console.Write(mensaje); // mensaje para requerir deposito

    while (!decimal.TryParse(Console.ReadLine(), out montoOperacion) || montoOperacion <= 0) // validacion monto deposito
    {
        Console.WriteLine("Mensaje: Debe ingresar un monto válido y mayor a 0!");
        Console.Write(mensaje);
    }
   
    Console.WriteLine("\n***** Monto agregado satisfactoriamente *****");

    saldoDisponible += montoOperacion; // adiciona nuevo monto a balnace actual

    MostrarBalance(); // Funcion mostrar balance modificado

    return saldoDisponible;
    
}

decimal Retiro(string mensaje) // Metodo Retiro
{
    Console.Write(mensaje); // Mensaje para requerir retiro

    while(true)
    {
        
        if (!decimal.TryParse(Console.ReadLine(), out montoOperacion) || montoOperacion <= 0) // lee el monto retirado
            {
                Console.WriteLine("\nMensaje!: Debe ingresar un monto válido y mayor a 0.");
            }

        else if (montoOperacion > saldoDisponible) // validacion fondos suficientes
            {
                Console.WriteLine("\nMensaje!: Fondos insuficientes.");
            }
            
        else
            {
                break; // si verdadero, sale del bucle
            }
            
            Console.Write(mensaje); // Mensaje para requerir retiro
    }


    saldoDisponible -= montoOperacion; // resta monto retirado
    Console.WriteLine($"\nHa retirado: $RD{montoOperacion:N2}"); // muestra total retirado

    MostrarBalance(); // Metodo balance
    return saldoDisponible; // retorna el balance modificado
    
}

// FIN METODOS_____________________________________________________________________________________________

if (estadoCuentaActiva) // validacion estado de cuenta
{
    // mensaje bienvenida
    Console.WriteLine($"\nBienvenido a DIGIT-BANK {nombreCliente}.");
    Console.WriteLine("\nElija una opción según sus necesidades:");
    
    // loop de opciones
    do
    {
        MostrarMenu(); //  MENU
            
            // loop mientras validacion de entrada
            while (!int.TryParse(Console.ReadLine(), out opcionMenu) || opcionMenu < 1 || opcionMenu > 4)
            {
                // mensaje de error
                Console.WriteLine("Mensaje: Debe elegir un número del menú de opciones!");
                
                MostrarMenu(); // MENU
            }

            // menu switch
            switch (opcionMenu)
            {   
                // consulta de saldo disponible ****************************************************************************************
                case 1:
                Console.WriteLine("\n1. * Solicitud de balance disponible. *");
                MostrarBalance(); // Metodo balance
                break;
                
                // deposito a cuenta ****************************************************************************************************
                case 2:
                Console.WriteLine("\n2. ** Depósito a cuenta. **");
                Deposito("\n- Que monto desea depositar: "); // Metodo deposito
                break;

                // retiro desde cuenta **************************************************************************************************
                case 3:
                Console.WriteLine("\n3. *** Retiro. ***");
                Retiro("\n- Que monto desea retirar: "); // Metodo Retiro
                break;
            }
            // fin del menu switch

        
    } while (opcionMenu != 4); // si es mayor, tambien saldra
}
else if (!estadoCuentaActiva) // valida estado de cuenta
{
    Console.WriteLine("Su cuenta está inactiva. Comuníquese con nuestras oficinas para más información.");
}
else
{
    // mensaje de invalidacion de cuenta
    Console.WriteLine($"Lo sentimos {nombreCliente}, no se pudo validar su cuenta. Por favor, intente más tarde.");
}

// fin loop de opciones
// agradecimiento y despedida con nombre usuario
Console.WriteLine($"\nGracias por utilizar nuestros servicios Sr. {nombreCliente}.");
Console.WriteLine("\t\nDIGIT-BANK 'Su confianza es nuesto interés'");