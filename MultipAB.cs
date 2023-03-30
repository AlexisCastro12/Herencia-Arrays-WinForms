using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHerenciaMat1
{
    class MultipAB : MatB
    {
        double[,] multipliMat;

        public MultipAB(int ma, int na, int mb, int nb) : base(ma, na, mb, nb)
        {
            multipliMat = new double[ma, nb];
        }

        public void MultMatAB(ref double[,] mltpAyB, double[,] a, double[,] b)
        {
            datosA(ref a);
            datosb(ref b);
            double acum = 0.0;
            for (int i = 0; i < ma; i++)
            {
                for (int j = 0; j < nb; j++)
                {
                    for (int k = 0; k < na; k++)
                    {
                        acum += a[i, k] * b[k, j];
                    }
                    multipliMat[i, j] = acum;
                    acum = 0;
                }
            }
            mltpAyB = multipliMat;
        }
    }
}
