class PagoTarjeta : Pago
{
    public PagoTarjeta(string titular, double monto)
     : base(titular, monto)
    {

    }
    public override double CalcularComision()
    {
        return Monto * 0.02;
    }
}
