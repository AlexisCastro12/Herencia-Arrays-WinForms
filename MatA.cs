using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHerenciaMat1
{
    class MatA
    {
        protected int ma, na;
        protected double[,] a;

        public MatA(int ma, int na)
        {
            this.ma = ma;
            this.na = na;

            a = new double[ma, na];
        }

        public void datosA(ref double[,] a)
        {
            this.a = a;
        }
    }
}
