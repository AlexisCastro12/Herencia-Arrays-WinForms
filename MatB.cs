using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHerenciaMat1
{
    class MatB : MatA
    {
        protected int mb, nb;
        protected double[,] b;

        public MatB(int ma, int na, int mb, int nb) : base(ma, na)
        {
            this.mb = mb;
            this.nb = nb;

            b = new double[mb, nb];
        }

        public void datosb(ref double[,] b)
        {
            this.b = b;
        }
    }
}
