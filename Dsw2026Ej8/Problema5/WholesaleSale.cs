using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema5
{
    public class WholesaleSale : Sale
    {
        public WholesaleSale(decimal monto) : base(monto) { }
        public override decimal CalcularTotal()
        {
            return monto * 0.9m;
        }
    }
}
