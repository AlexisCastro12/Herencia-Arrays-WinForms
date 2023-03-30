using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHerenciaMat1
{
    class RestaAB : MatB
    {
        double[,] restaMat;

        public RestaAB(int ma, int na, int mb, int nb) : base(ma, na, mb, nb)
        {
            restaMat = new double[ma, na];
        }

        public void SumarMatAB(ref double[,] restaAyB, double[,] a, double[,] b)
        {
            datosA(ref a);
            datosb(ref b);
            for (int i = 0; i < ma; i++)
            {
                for (int j = 0; j < na; j++)
                {
                    restaMat[i, j] = a[i, j] - b[i, j];
                }
            }
            restaAyB = restaMat;
        }
    }
}
