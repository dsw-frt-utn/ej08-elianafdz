using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public static string CompararCopias(int originalValue, Product product)
        {
           int copiaValor = originalValue;

            copiaValor++;

            Product copiaProducto = product;

            copiaProducto.SetDescription("Modificado");

            return $"{originalValue}-{copiaValor}-{product.GetDescription()}";
        }
    }
}
