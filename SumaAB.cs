using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHerenciaMat1
{
    class SumaAB : MatB
    {
        double[,] sumaMat;

        public SumaAB(int ma, int na, int mb, int nb) : base(ma, na, mb, nb)
        {
            sumaMat = new double[ma, na];
        }

        public void SumarMatAB(ref double[,] sumaAyB, double[,] a, double[,] b)
        {
            datosA(ref a);
            datosb(ref b);
            for (int i = 0; i < ma; i++)
            {
                for (int j = 0; j < na; j++)
                {
                    sumaMat[i, j] = a[i, j] + b[i, j];
                }
            }
            sumaAyB = sumaMat;
        }
    }
}
