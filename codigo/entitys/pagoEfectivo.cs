    using System;

    class PagoEfectivo : Pago
    {
        public PagoEfectivo(string titular, double monto)
            : base(titular, monto)
        {

        }

        public override double CalcularComision()
        {
            return -(Monto * 0.10);
        }
    }