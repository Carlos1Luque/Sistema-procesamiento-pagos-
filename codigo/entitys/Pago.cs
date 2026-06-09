using System;

abstract class Pago
{
    private string titular;
    private double monto;

    public string Titular { get { return this.titular; } set { this.titular = value; } }
    public double Monto { get { return this.monto; } set { this.monto = value; } }

    public Pago(string titular, double monto)
    {
        Titular = titular;
        Monto = monto;
    }

    public abstract double CalcularComision();

    public virtual void MostrarInformacion()
    {
        Console.WriteLine("Titular: " + Titular);
        Console.WriteLine("Monto original: $" + Monto);
        Console.WriteLine("Comisión: $" + CalcularComision());
        Console.WriteLine("Monto total a pagar: $" + (Monto + CalcularComision()));
    }
    public void ProcesarPago()
    {
        double comision;

        comision = CalcularComision();

        Console.WriteLine("Procesando pago...");
        Console.WriteLine("Comisión aplicada: $" + comision);
        Console.WriteLine("Monto final: $" + (Monto + comision));
        Console.WriteLine("Pago realizado correctamente.");
    }
}