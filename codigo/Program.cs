using System;
using System.Collections.Generic; // Agregado por las dudas para que te lea List

class Program
{
    static List<PagoTarjeta> pagosTarjeta = new List<PagoTarjeta>();
    static List<PagoEfectivo> pagosEfectivo = new List<PagoEfectivo>();
    static List<PagoTransferencia> pagosTransferencia = new List<PagoTransferencia>();

    static void Main()
    {
        Console.WriteLine("Bienvenido al sistema de pagos C y D S.A.");
        while (true)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Registrar pago");
            Console.WriteLine("2. Procesar pago");
            Console.WriteLine("3. Mostrar información");
            Console.WriteLine("4. Salir");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    RegistrarPago();
                    break;
                case 2:
                    ProcesarPago();
                    break;
                case 3:
                    MostrarInformacion();
                    break; 
                case 4:
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 4.");
                    break;
            }
        } 
    }
    static void RegistrarPago() 
    {
        Console.WriteLine("Seleccione el método de pago: (Tarjeta/Efectivo/Transferencia)");
        String metodoPago = Console.ReadLine();
        Console.WriteLine("Ingrese el nombre del titular:");
        String titular = Console.ReadLine();
        Console.WriteLine("Ingrese el monto a pagar:");
        double monto = Convert.ToDouble(Console.ReadLine());

        if (metodoPago.ToLower() == "tarjeta")
        {
            PagoTarjeta pagoTarjeta = new PagoTarjeta(titular, monto);
            pagosTarjeta.Add(pagoTarjeta);
            Console.WriteLine("Pago con tarjeta guardado exitosamente.");
        }
        else if (metodoPago.ToLower() == "transferencia")
        {
            PagoTransferencia pagoTransferencia = new PagoTransferencia(titular, monto);
            pagosTransferencia.Add(pagoTransferencia);
            Console.WriteLine("Pago con transferencia guardado exitosamente.");
        }
        else if (metodoPago.ToLower() == "efectivo")
        {
            PagoEfectivo pagoEfectivo = new PagoEfectivo(titular, monto);
            pagosEfectivo.Add(pagoEfectivo);
            Console.WriteLine("Pago en efectivo guardado exitosamente.");
        }
        else
        {
            Console.WriteLine("Método de pago no válido. Por favor, seleccione Tarjeta, Efectivo o Transferencia.");
        }
    }

    static void ProcesarPago()
    {
        Console.WriteLine("Seleccione el método de pago a procesar: (Tarjeta/Efectivo/Transferencia)");
        String metodoPago = Console.ReadLine();
        if (metodoPago.ToLower() == "tarjeta")
        {
          foreach (var pago in pagosTarjeta)
            {
                Console.WriteLine("Su monto a pagar es: $" + pago.Monto);
                Console.WriteLine("Procesando pago con tarjeta...");
                pago.ProcesarPago();
                Console.WriteLine("Pago con tarjeta procesado exitosamente.");
            }
        }
        else if (metodoPago.ToLower() == "transferencia")
        {
            foreach (var pago in pagosTransferencia)
            {
                Console.WriteLine("Su monto a pagar es: $" + pago.Monto);
                Console.WriteLine("Procesando pago con transferencia...");
                pago.ProcesarPago();
                Console.WriteLine("Pago con transferencia procesado exitosamente.");
            }
        }
        else if (metodoPago.ToLower() == "efectivo")
        {
            foreach (var pago in pagosEfectivo)
            {   Console.WriteLine("Su monto a pagar es: $" + pago.Monto);
                Console.WriteLine("Procesando pago en efectivo...");
                pago.ProcesarPago();
                Console.WriteLine("Pago en efectivo procesado exitosamente.");
            }
        }
        else
        {
            Console.WriteLine("Método de pago no válido. Por favor, seleccione Tarjeta, Efectivo o Transferencia.");
        }
    }

    static void MostrarInformacion()
    {
       Console.WriteLine("Seleccione el método de pago para mostrar información: (Tarjeta/Efectivo/Transferencia)");
        String metodoPago = Console.ReadLine();
        if (metodoPago.ToLower() == "tarjeta")
        {
            foreach (var pago in pagosTarjeta)
            {
                pago.MostrarInformacion();
                Console.WriteLine("Gracias por confiar en nuestro sistema de pagos.");
            }
        }
        else if (metodoPago.ToLower() == "transferencia")
        {
            foreach (var pago in pagosTransferencia)
            {
                pago.MostrarInformacion();
                Console.WriteLine("Gracias por confiar en nuestro sistema de pagos.");
            }
        }
        else if (metodoPago.ToLower() == "efectivo")
        {
            foreach (var pago in pagosEfectivo)
            {
                pago.MostrarInformacion();
                Console.WriteLine("Gracias por confiar en nuestro sistema de pagos.");
            }
        }
        else
        {
            Console.WriteLine("Método de pago no válido. Por favor, seleccione Tarjeta, Efectivo o Transferencia.");
        }
    }
} 
