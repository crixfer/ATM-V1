// ATM Project V1

// variables
string nombreCliente = string.Empty;
string numeroCuenta = string.Empty;

bool estadoCuenta = false;

decimal saldoDisponible = 25000m;
decimal montoOperacion = 0m;

int opcionMenu = 0;

// Fin variables

// inicio sistema ditigal
Console.WriteLine("********** CAJERO AUTOMATICO DIGITAL **********");

Console.WriteLine("\nEscriba su nombre completo, por favor.: ");
nombreCliente = Console.ReadLine();

Console.WriteLine($"\nBienvenido a DigitBank {nombreCliente}.");
Console.WriteLine("Elija una opción según sus necesidades:");



// loop de opciones
do
{
    Console.WriteLine("\t\n***** Menú de opciones *****");
    
    // menu de opciones
    Console.WriteLine("1. Consulta de balance disponible.");
    Console.WriteLine("2. Depósito a cuenta.");
    Console.WriteLine("3. Retiro.");
    Console.WriteLine("4. Salir del menú.");
    // fin menu de opciones

    // validacion entrada del menu
    if (!int.TryParse(Console.ReadLine(), out opcionMenu))
    {
        Console.WriteLine("Debe introducir un número para proceder con una opción del menú.");
    }
    else 
    {
        switch (opcionMenu)
        {   
            // consulta de saldo disponible
            case 1:
            Console.WriteLine("1. Solicitud de balance disponible.");
            Console.WriteLine($"Su balance actual es $RD{saldoDisponible:N2}");
            break;
            
            // deposito a cuenta
            case 2:
            Console.WriteLine("2. Depósito a cuenta.");
            Console.WriteLine("Que monto desea depositar:");
            if (decimal.TryParse(Console.ReadLine(), out montoOperacion))
                {
                    saldoDisponible += montoOperacion;
                }
            else
                {
                    Console.WriteLine("Debe ingresar un monto mayor a 0.");
                }
            break;

            // retiro desde cuenta
            case 3:
            Console.WriteLine("3. Retiro.");
            Console.WriteLine("Que monto desea retirar?");
            if (decimal.TryParse(Console.ReadLine(), out montoOperacion))
                {
                    saldoDisponible -= montoOperacion;
                }
            else
                {
                    Console.WriteLine("Debe ingresar un monto mayor a 0.");
                }
            break;


        }

    }

    
} while (opcionMenu < 4 && opcionMenu > 0);
// fin loop de opciones

Console.WriteLine($"Gracias por utilizar nuestros servicios Sr./Sra. {nombreCliente}");
Console.WriteLine("DIGITBANK. Su seguridad es nuesto interés.");