using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public abstract class Sale
    {
        protected decimal _importe;

        public decimal GetImporte()
        {
            return _importe;
        }

        public virtual decimal CalculateTotal()
        {
            return 0m;
        }
    }
}
