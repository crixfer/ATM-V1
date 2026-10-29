	Algoritmo CajeroAutomaticoDigital
		
		// Declaracion de variables
		Definir nombreCliente, numeroCuenta Como Cadena
		Definir estadoCuentaActiva Como Logico
		Definir saldoDisponible, montoOperacion Como Real
		Definir opcionMenu, intentoAcceso Como Entero
		
		nombreCliente <- "Christopher Portorreal"
		numeroCuenta <- ""
		estadoCuentaActiva <- Falso
		
		saldoDisponible <- 25000
		montoOperacion <- 0
		opcionMenu <- 0
		intentoAcceso <- 3
		
		// Inicio del sistema
		Escribir "********** CAJERO AUTOMATICO DIGITAL **********"
		Escribir ""
		Escribir "Elija un numero de cuenta:"
		Escribir "Numeros de cuentas de prueba disponibles:"
		Escribir "1. 123456 (Cuenta activa)"
		Escribir "2. 111222 (Cuenta inactiva)"
		Escribir ""
		Escribir "Ingrese el numero de cuenta:"
		Leer numeroCuenta
		
		// Validacion de acceso
		Mientras numeroCuenta <> "1" Y intentoAcceso > 0 Hacer
			
			Escribir "** Numero de cuenta no disponible **"
			Escribir "Intente nuevamente."
			
			intentoAcceso <- intentoAcceso - 1
			
			Escribir "Intentos disponibles: ", intentoAcceso
			
			Si intentoAcceso > 0 Entonces
				Escribir "Ingrese nuevamente el numero de cuenta:"
				Leer numeroCuenta
			FinSi
			
		FinMientras
		
		// Activacion de la cuenta
		Si numeroCuenta = "1" Entonces
			estadoCuentaActiva <- Verdadero
		FinSi
		
		// Acceso al menu principal
		Si estadoCuentaActiva = Verdadero Entonces
			
			Escribir ""
			Escribir "Bienvenido a DIGIT-BANK ", nombreCliente
			Escribir "Elija una opcion segun sus necesidades."
			
			Repetir
				
				Escribir ""
				Escribir "********** MENU DE OPCIONES **********"
				Escribir "1. Consulta de balance disponible"
				Escribir "2. Deposito a cuenta"
				Escribir "3. Retiro"
				Escribir "4. Salir del menu"
				Escribir "**************************************"
				Escribir "Seleccione una opcion:"
				Leer opcionMenu
				
				Segun opcionMenu Hacer
					
						// Consulta de balance
					1:
						Escribir ""
						Escribir "SOLICITUD DE BALANCE DISPONIBLE"
						Escribir "--------------------------------"
						Escribir "Su balance actual es: RD$", saldoDisponible
						Escribir "--------------------------------"
						
						// Deposito a cuenta
					2:
						Escribir ""
						Escribir "DEPOSITO A CUENTA"
						Escribir "Que monto desea depositar?"
						Leer montoOperacion
						
						Si montoOperacion > 0 Entonces
							
							saldoDisponible <- saldoDisponible + montoOperacion
							
							Escribir "Monto agregado satisfactoriamente."
							Escribir "Su balance actual es: RD$", saldoDisponible
							
						SiNo
							
							Escribir "Error: Debe ingresar un monto mayor que cero."
							
						FinSi
						
						// Retiro de efectivo
					3:
						Escribir ""
						Escribir "RETIRO"
						Escribir "Que monto desea retirar?"
						Leer montoOperacion
						
						Si montoOperacion > 0 Entonces
							
							Si montoOperacion <= saldoDisponible Entonces
								
								saldoDisponible <- saldoDisponible - montoOperacion
								
								Escribir "Ha retirado: RD$", montoOperacion
								Escribir "Su balance actual es: RD$", saldoDisponible
								
							SiNo
								
								Escribir "Fondos insuficientes."
								
							FinSi
							
						SiNo
							
							Escribir "Debe ingresar un monto mayor que cero."
							
						FinSi
						
						// Salir del menu
					4:
						Escribir "Saliendo del menu..."
						
					De Otro Modo:
						Escribir "Error: Debe elegir una opcion del 1 al 4."
						
				FinSegun
				
			Hasta Que opcionMenu = 4
			
		SiNo
			
			Escribir "Su cuenta no esta activa o el numero ingresado no es valido."
			Escribir "Comuniquese con nuestras oficinas para mas informacion."
			
		FinSi
		
		// Despedida
		Escribir ""
		Escribir "Gracias por utilizar nuestros servicios ", nombreCliente
		Escribir "DIGIT-BANK: Su confianza es nuestro interes."
		
FinAlgoritmo
