using System;

class Program
{
    static void Main(string[] args)
    {
        string titular;
        double monto;
        int opcion;
        Pago pago;

        Console.Write("Ingrese el titular: ");
        titular = Console.ReadLine();

        Console.Write("Ingrese el monto: ");
        monto = double.Parse(Console.ReadLine());

        Console.WriteLine("1 - Tarjeta");
        Console.WriteLine("2 - Transferencia");
        Console.WriteLine("3 - Efectivo");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                pago = new PagoTarjeta(titular, monto);
                break;

            case 2:
                pago = new PagoTransferencia(titular, monto);
                break;

            case 3:
                pago = new PagoEfectivo(titular, monto);
                break;

            default:
                Console.WriteLine("La opción no e svalida");
                return;
        }

        pago.MostrarInformacion();

        pago.ProcesarPago();
    }
}
