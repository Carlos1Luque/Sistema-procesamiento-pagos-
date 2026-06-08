using System;
class Program
{
static List<PagoTarjeta> pagosTarjeta = new List<PagoTarjeta>();
static List<PagoEfectivo> pagosEfectivo = new List<PagoEfectivo>();
static List<PagoTransferencia> pagosTransferencia = new List<PagoTransferencia>();
static void Main()
    {
        Console.WriteLine("Bienvenido al sistema de pagos C y D S.A.");
        Console.WriteLine("Seleccione el método de pago: (Tarjeta/Efectivo/Transferencia)");
        String metodoPago = Console.ReadLine(); 
        Console.WriteLine("Ingrese el nombre del titular:");
        String titular = Console.ReadLine();
        Console.WriteLine("Ingrese el monto a pagar:");
        double monto = Convert.ToDouble(Console.ReadLine());
        if(metodoPago.ToLower() == "tarjeta")
        {
            PagoTarjeta pagoTarjeta = new PagoTarjeta(titular, monto); 
            pagosTarjeta.Add(pagoTarjeta);
            
        }
    }
}


