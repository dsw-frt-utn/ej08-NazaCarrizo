using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copiaEntero = originalValue;
            copiaEntero++;
            Product copiaProduct = product;
            copiaProduct.ModificarDescripcion("NUEVA DESCRIPCION");
            return $"{originalValue}-{copiaEntero}-{product.GetDescription()}";
            //como copiaProduct y product hacen referencia al mismo objeto, da igual cual descripcion se imprima
            //es la misma
        }
    }
}
