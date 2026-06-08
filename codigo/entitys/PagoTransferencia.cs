class PagoTransferencia : Pago
{
    public PagoTransferencia(string titular, double monto)
        : base(titular, monto)
    {

    }
    public override double CalcularComision()
    {
        
    return -(Monto * 0.10);
    }
}