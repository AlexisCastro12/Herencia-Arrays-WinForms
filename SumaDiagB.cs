using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHerenciaMat1
{
    class SumaDiagB : MatB
    {
        double sumaD;

        public SumaDiagB(int ma, int na, int mb, int nb) : base(ma, na, mb, nb)
        {
            sumaD = 0;
        }

        public void SumarDB(ref double sumaDB, double[,] a, double[,] b)
        {
            datosA(ref a);
            datosb(ref b);
            for (int i = 0; i < ma; i++)
            {
                for (int j = 0; j < nb; j++)
                {
                    if (i == j)
                    {
                        sumaD += b[i,j];
                    }
                }
            }
            sumaDB = sumaD;
            sumaD = 0;
        }
    }
}
