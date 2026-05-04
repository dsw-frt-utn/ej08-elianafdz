using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema5
{
    public class Sale
    {
        protected decimal monto;
        public Sale(decimal monto)
        {
            this.monto = monto;
        }
        public virtual decimal CalcularTotal()
        {
        return monto;
        }
    }
}
