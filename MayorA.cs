using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHerenciaMat1
{
    class MayorA : MatA
    {
        double mayor;

        public MayorA(int m, int n) : base(m, n)
        {
            mayor = 0;
        }

        public void CalcularMayor(ref double may, double[,] a)
        {
            datosA(ref a);
            mayor = a[0, 0];
            for (int i = 0; i < ma; i++)
            {
                for (int j = 0; j < na; j++)
                {
                    if (a[i, j] > mayor)
                    {
                        mayor = a[i, j];
                    }
                }
            }
            may = mayor;
        }
    }
}
