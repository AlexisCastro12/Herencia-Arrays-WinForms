using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHerenciaMat1
{
    class SumaElem : MatA
    {
        double suma;

        public SumaElem(int m, int n) : base(m,n)
        {
            suma = 0;
        }

        public void SumarEl(ref double sum, double [,] a)
        {
            datosA(ref a);
            for (int i = 0; i < ma; i++)
            {
                for (int j = 0; j < na; j++)
                {
                    suma += a[i, j];
                }
            }
            sum = suma;
        }
    }
}
