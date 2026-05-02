using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {

        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int suma=0;
            int cont = 0;
            if (nota1.HasValue == true)
            {
                if (nota1 >= 0 && nota1 <= 10)
                {
                    suma = suma + (int)nota1;
                    cont++;
                }
            }
            if (nota2.HasValue == true)
            {
                if (nota2 >= 0 && nota2 <= 10)
                {
                    suma = suma + (int)nota2;
                    cont++;
                }
            }
            if (nota3.HasValue == true)
            {
                if (nota3 >= 0 && nota3 <= 10)
                {
                    suma = suma + (int)nota3;
                    cont++;
                }
            }

            if (cont != 0)
            {
                return (double)suma / cont;
            }
            else
            {
                return 0;
            }
        }
    }
}
