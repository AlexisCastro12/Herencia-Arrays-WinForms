using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFHerenciaMat1
{
    public partial class Form1 : Form
    {
        int m, n;
        double[,] a;
        double[,] b;
        bool Habilitar = false; //Obliga al usuario a crear y leer las matrices correctamente para desbloquear las funciones

        public Form1()
        {
            InitializeComponent();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Castro.exe");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTamano_Click(object sender, EventArgs e)
        {
            try
            {
                m = int.Parse(TxBm.Text);
                n = int.Parse(TxBn.Text);
                a = new double[m, n];
                b = new double[m, n];
                dataGridViewA.RowCount = m;
                dataGridViewB.RowCount = m;
                dataGridViewA.ColumnCount = n;
                dataGridViewB.ColumnCount = n;
                for (int i = 0; i < m; i++)
                {
                    dataGridViewA.Rows[i].HeaderCell.Value = "a_" + (i + 1) + " j";
                    dataGridViewB.Rows[i].HeaderCell.Value = "b_" + (i + 1) + " j";
                }

                for (int j = 0; j < n; j++)
                {
                    dataGridViewA.Columns[j].Name = "a_i " + (j + 1);
                    dataGridViewB.Columns[j].Name = "b_i " + (j + 1);
                    dataGridViewA.Columns[j].Width = (dataGridViewA.Width - 10) / 4;
                    dataGridViewB.Columns[j].Width = (dataGridViewB.Width - 10) / 4;
                }

                for (int i = 0; i < m; i++)      //  Inicializar/Rellenar
                    for (int j = 0; j < n; j++)
                        dataGridViewA.Rows[i].Cells[j].Value = " ";

                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                        dataGridViewB.Rows[i].Cells[j].Value = " ";

                txtErrores.BackColor = SystemColors.Control;
                txtErrores.ForeColor = Color.Black;
                txtErrores.Text = "LISTO !!!";
                Habilitar = true;
            }
            catch
            {
                txtErrores.BackColor = Color.Red;
                txtErrores.ForeColor = Color.White;
                txtErrores.Text = "ERROR AL DIMENSIONAR LAS MATRICES";
                Habilitar = false;
            }
        }

        private void btnLeerMat_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        a[i, j] = double.Parse(dataGridViewA.Rows[i].Cells[j].Value.ToString());
                        b[i, j] = double.Parse(dataGridViewB.Rows[i].Cells[j].Value.ToString());
                    }
                }
                txtErrores.BackColor = SystemColors.Control;
                txtErrores.ForeColor = Color.Black;
                txtErrores.Text = "LISTO !!!";

                if (Habilitar) {
                    btnPonerA.Enabled = true;
                    btnPonerB.Enabled = true;
                    groupBox2.Enabled = true;
                }
            }
            catch
            {
                txtErrores.BackColor = Color.Red;
                txtErrores.ForeColor = Color.White;
                txtErrores.Text = "ERROR DE LECTURA DE DATOS EN LAS MATRICES (SOLO SE PERMITEN NÚMEROS)";
                btnPonerA.Enabled = false;
                btnPonerB.Enabled = false;
                groupBox2.Enabled = false;
            }
        }

        private void btnPonerA_Click(object sender, EventArgs e)
        {
                LBxSalida.Items.Add("\tMATRIZ [A]:");
                string aux;
                for (int i = 0; i < m; i++)
                {
                    aux = "  ";
                    for (int j = 0; j < n; j++)
                    {
                        aux += a[i, j] + "  ";
                    }
                    LBxSalida.Items.Add(aux);
                }
        }

        private void btnPonerB_Click(object sender, EventArgs e)
        {
            string aux;
            LBxSalida.Items.Add("\tMATRIZ [B]:");
            for (int i = 0; i < m; i++)
            {
                aux = "  ";
                for (int j = 0; j < n; j++)
                {
                    aux += b[i, j] + "  ";
                }
                LBxSalida.Items.Add(aux);
            }
        }

        private void btnSumaElemA_Click(object sender, EventArgs e)
        {
            double sum = 0;
            SumaElem ObjSE = new SumaElem(m, n);
            ObjSE.SumarEl(ref sum, a);
            LBxSalida.Items.Add(" ");
            LBxSalida.Items.Add("Suma de elementos de [A] = " + sum);
            LBxSalida.Items.Add(" ");
            txtErrores.BackColor = SystemColors.Control;
            txtErrores.ForeColor = Color.Black;
            txtErrores.Text = "LISTO !!!";
        }

        private void btnSumaAB_Click(object sender, EventArgs e)
        {
            SumaAB ObjSum = new SumaAB(m, n, m, n);
            double[,] sumaAyB = new double[m, n];
            ObjSum.SumarMatAB(ref sumaAyB, a, b);
            string aux;
            LBxSalida.Items.Add("\t  [A] + [B]:");
            for (int i = 0; i < m; i++)
            {
                aux = "  ";
                for (int j = 0; j < n; j++)
                {
                    aux += sumaAyB[i, j] + "  ";
                }
                LBxSalida.Items.Add(aux);
            }
            txtErrores.BackColor = SystemColors.Control;
            txtErrores.ForeColor = Color.Black;
            txtErrores.Text = "LISTO !!!";
        }

        private void btnRestaAB_Click(object sender, EventArgs e)
        {
            RestaAB ObjSum = new RestaAB(m, n, m, n);
            double[,] restaAyB = new double[m, n];
            ObjSum.SumarMatAB(ref restaAyB, a, b);
            string aux;
            LBxSalida.Items.Add("\t  [A] - [B]:");
            for (int i = 0; i < m; i++)
            {
                aux = "  ";
                for (int j = 0; j < n; j++)
                {
                    aux += restaAyB[i, j] + "  ";
                }
                LBxSalida.Items.Add(aux);
            }
            txtErrores.BackColor = SystemColors.Control;
            txtErrores.ForeColor = Color.Black;
            txtErrores.Text = "LISTO !!!";
        }

        private void btnSumaB_Click(object sender, EventArgs e)
        {
            if (m == n)
            {
                SumaDiagB ObjSDiagB = new SumaDiagB(m, n, m, n);
                double sumadiagb = 0;
                ObjSDiagB.SumarDB(ref sumadiagb, a, b);
                LBxSalida.Items.Add(" ");
                LBxSalida.Items.Add("Suma de diagonal principal de [B] = " + sumadiagb);
                LBxSalida.Items.Add(" ");

                txtErrores.BackColor = SystemColors.Control;
                txtErrores.ForeColor = Color.Black;
                txtErrores.Text = "LISTO !!!";
            }
            else
            {
                txtErrores.BackColor = Color.Red;
                txtErrores.ForeColor = Color.White;
                txtErrores.Text = "La matriz no es cuadrada... No tiene Diagonal Principal";
            }
        }

        private void btnMayorA_Click(object sender, EventArgs e)
        {
            try
            {
                MayorA objmay = new MayorA(m, n);
                double mayor = 0;
                objmay.CalcularMayor(ref mayor, a);
                LBxSalida.Items.Add(" ");
                LBxSalida.Items.Add("Elemento mayor de [A] = " + mayor);
                LBxSalida.Items.Add(" ");

                txtErrores.BackColor = SystemColors.Control;
                txtErrores.ForeColor = Color.Black;
                txtErrores.Text = "LISTO !!!";
            }
            catch
            {
                txtErrores.BackColor = Color.Red;
                txtErrores.ForeColor = Color.White;
                txtErrores.Text = "Error al extraer el elemento mayor de la MATRIZ [A]";
            }
        }



        private void btnMultAB_Click(object sender, EventArgs e)
        {
                if (m == n)
                {
                    MultipAB ObjSum = new MultipAB(m, n, m, n);
                    double[,] multiplicarAyB = new double[m, n];
                    ObjSum.MultMatAB(ref multiplicarAyB, a, b);
                    string aux;
                    LBxSalida.Items.Add("\t  [A] * [B]:");
                    for (int i = 0; i < m; i++)
                    {
                        aux = "  ";
                        for (int j = 0; j < n; j++)
                        {
                            aux += multiplicarAyB[i, j] + "  ";
                        }
                        LBxSalida.Items.Add(aux);
                    }

                    txtErrores.BackColor = SystemColors.Control;
                    txtErrores.ForeColor = Color.Black;
                    txtErrores.Text = "LISTO !!!";
                }
                else
                {
                    txtErrores.BackColor = Color.Red;
                txtErrores.ForeColor = Color.White;
                txtErrores.Text = "Error al multiplicar las matrices... Posible problema de incompatibilidad de dimensiones. Intenta crear matrices cuadradas (m=n)";
                }
        }
    }
}
