
namespace WFHerenciaMat1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxBm = new System.Windows.Forms.TextBox();
            this.TxBn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTamano = new System.Windows.Forms.Button();
            this.btnLeerMat = new System.Windows.Forms.Button();
            this.btnPonerB = new System.Windows.Forms.Button();
            this.btnPonerA = new System.Windows.Forms.Button();
            this.LBxSalida = new System.Windows.Forms.ListBox();
            this.btnSumaAB = new System.Windows.Forms.Button();
            this.btnSumaElemA = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMayorA = new System.Windows.Forms.Button();
            this.btnSumaB = new System.Windows.Forms.Button();
            this.btnMultAB = new System.Windows.Forms.Button();
            this.btnRestaAB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtErrores = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewA = new System.Windows.Forms.DataGridView();
            this.dataGridViewB = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).BeginInit();
            this.SuspendLayout();
            // 
            // TxBm
            // 
            this.TxBm.Location = new System.Drawing.Point(33, 40);
            this.TxBm.Name = "TxBm";
            this.TxBm.Size = new System.Drawing.Size(50, 24);
            this.TxBm.TabIndex = 1;
            // 
            // TxBn
            // 
            this.TxBn.Location = new System.Drawing.Point(155, 40);
            this.TxBn.Name = "TxBn";
            this.TxBn.Size = new System.Drawing.Size(50, 24);
            this.TxBn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filas[m]:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(133, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Columnas[n]:";
            // 
            // btnTamano
            // 
            this.btnTamano.Location = new System.Drawing.Point(79, 70);
            this.btnTamano.Name = "btnTamano";
            this.btnTamano.Size = new System.Drawing.Size(75, 23);
            this.btnTamano.TabIndex = 5;
            this.btnTamano.Text = "Tamaño";
            this.btnTamano.UseVisualStyleBackColor = true;
            this.btnTamano.Click += new System.EventHandler(this.btnTamano_Click);
            // 
            // btnLeerMat
            // 
            this.btnLeerMat.Location = new System.Drawing.Point(555, 150);
            this.btnLeerMat.Name = "btnLeerMat";
            this.btnLeerMat.Size = new System.Drawing.Size(101, 52);
            this.btnLeerMat.TabIndex = 6;
            this.btnLeerMat.Text = "Leer Matrices";
            this.btnLeerMat.UseVisualStyleBackColor = true;
            this.btnLeerMat.Click += new System.EventHandler(this.btnLeerMat_Click);
            // 
            // btnPonerB
            // 
            this.btnPonerB.Enabled = false;
            this.btnPonerB.Location = new System.Drawing.Point(555, 291);
            this.btnPonerB.Name = "btnPonerB";
            this.btnPonerB.Size = new System.Drawing.Size(101, 23);
            this.btnPonerB.TabIndex = 9;
            this.btnPonerB.Text = "Imprimir B";
            this.btnPonerB.UseVisualStyleBackColor = true;
            this.btnPonerB.Click += new System.EventHandler(this.btnPonerB_Click);
            // 
            // btnPonerA
            // 
            this.btnPonerA.Enabled = false;
            this.btnPonerA.Location = new System.Drawing.Point(555, 238);
            this.btnPonerA.Name = "btnPonerA";
            this.btnPonerA.Size = new System.Drawing.Size(101, 23);
            this.btnPonerA.TabIndex = 8;
            this.btnPonerA.Text = "Imprimir A";
            this.btnPonerA.UseVisualStyleBackColor = true;
            this.btnPonerA.Click += new System.EventHandler(this.btnPonerA_Click);
            // 
            // LBxSalida
            // 
            this.LBxSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LBxSalida.FormattingEnabled = true;
            this.LBxSalida.HorizontalScrollbar = true;
            this.LBxSalida.ItemHeight = 18;
            this.LBxSalida.Location = new System.Drawing.Point(714, 148);
            this.LBxSalida.Name = "LBxSalida";
            this.LBxSalida.Size = new System.Drawing.Size(303, 274);
            this.LBxSalida.TabIndex = 10;
            // 
            // btnSumaAB
            // 
            this.btnSumaAB.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnSumaAB.Location = new System.Drawing.Point(21, 70);
            this.btnSumaAB.Name = "btnSumaAB";
            this.btnSumaAB.Size = new System.Drawing.Size(117, 23);
            this.btnSumaAB.TabIndex = 12;
            this.btnSumaAB.Text = "Suma A+B";
            this.btnSumaAB.UseVisualStyleBackColor = true;
            this.btnSumaAB.Click += new System.EventHandler(this.btnSumaAB_Click);
            // 
            // btnSumaElemA
            // 
            this.btnSumaElemA.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnSumaElemA.Location = new System.Drawing.Point(21, 26);
            this.btnSumaElemA.Name = "btnSumaElemA";
            this.btnSumaElemA.Size = new System.Drawing.Size(117, 23);
            this.btnSumaElemA.TabIndex = 11;
            this.btnSumaElemA.Text = "Suma Elementos [A]";
            this.btnSumaElemA.UseVisualStyleBackColor = true;
            this.btnSumaElemA.Click += new System.EventHandler(this.btnSumaElemA_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 20F);
            this.label3.Location = new System.Drawing.Point(250, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(521, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "PROYECTO - OPERACIONES CON MATRICES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(112, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "MATRIZ A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(372, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "MATRIZ B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(805, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "RESULTADOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxBm);
            this.groupBox1.Controls.Add(this.TxBn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTamano);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dimensiones";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMayorA);
            this.groupBox2.Controls.Add(this.btnSumaB);
            this.groupBox2.Controls.Add(this.btnMultAB);
            this.groupBox2.Controls.Add(this.btnRestaAB);
            this.groupBox2.Controls.Add(this.btnSumaElemA);
            this.groupBox2.Controls.Add(this.btnSumaAB);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox2.Location = new System.Drawing.Point(269, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 100);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones";
            // 
            // btnMayorA
            // 
            this.btnMayorA.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnMayorA.Location = new System.Drawing.Point(283, 71);
            this.btnMayorA.Name = "btnMayorA";
            this.btnMayorA.Size = new System.Drawing.Size(130, 23);
            this.btnMayorA.TabIndex = 16;
            this.btnMayorA.Text = "Elemento Mayor [A]";
            this.btnMayorA.UseVisualStyleBackColor = true;
            this.btnMayorA.Click += new System.EventHandler(this.btnMayorA_Click);
            // 
            // btnSumaB
            // 
            this.btnSumaB.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnSumaB.Location = new System.Drawing.Point(283, 26);
            this.btnSumaB.Name = "btnSumaB";
            this.btnSumaB.Size = new System.Drawing.Size(130, 23);
            this.btnSumaB.TabIndex = 15;
            this.btnSumaB.Text = "Suma Diag Principal [B]";
            this.btnSumaB.UseVisualStyleBackColor = true;
            this.btnSumaB.Click += new System.EventHandler(this.btnSumaB_Click);
            // 
            // btnMultAB
            // 
            this.btnMultAB.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnMultAB.Location = new System.Drawing.Point(156, 70);
            this.btnMultAB.Name = "btnMultAB";
            this.btnMultAB.Size = new System.Drawing.Size(117, 23);
            this.btnMultAB.TabIndex = 14;
            this.btnMultAB.Text = "Multiplicación A*B";
            this.btnMultAB.UseVisualStyleBackColor = true;
            this.btnMultAB.Click += new System.EventHandler(this.btnMultAB_Click);
            // 
            // btnRestaAB
            // 
            this.btnRestaAB.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnRestaAB.Location = new System.Drawing.Point(156, 26);
            this.btnRestaAB.Name = "btnRestaAB";
            this.btnRestaAB.Size = new System.Drawing.Size(117, 23);
            this.btnRestaAB.TabIndex = 13;
            this.btnRestaAB.Text = "Resta A-B";
            this.btnRestaAB.UseVisualStyleBackColor = true;
            this.btnRestaAB.Click += new System.EventHandler(this.btnRestaAB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFHerenciaMat1.Properties.Resources.MatricesLogo;
            this.pictureBox1.Location = new System.Drawing.Point(39, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WFHerenciaMat1.Properties.Resources.MatricesLogo;
            this.pictureBox2.Location = new System.Drawing.Point(869, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtErrores});
            this.statusStrip1.Location = new System.Drawing.Point(0, 445);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1034, 24);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtErrores
            // 
            this.txtErrores.BackColor = System.Drawing.SystemColors.Control;
            this.txtErrores.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.txtErrores.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.txtErrores.Name = "txtErrores";
            this.txtErrores.Size = new System.Drawing.Size(55, 19);
            this.txtErrores.Text = "Ready !!!";
            // 
            // dataGridViewA
            // 
            this.dataGridViewA.AllowUserToAddRows = false;
            this.dataGridViewA.AllowUserToDeleteRows = false;
            this.dataGridViewA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewA.Location = new System.Drawing.Point(30, 150);
            this.dataGridViewA.Name = "dataGridViewA";
            this.dataGridViewA.RowHeadersWidth = 65;
            this.dataGridViewA.Size = new System.Drawing.Size(225, 165);
            this.dataGridViewA.TabIndex = 24;
            // 
            // dataGridViewB
            // 
            this.dataGridViewB.AllowUserToAddRows = false;
            this.dataGridViewB.AllowUserToDeleteRows = false;
            this.dataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewB.Location = new System.Drawing.Point(290, 148);
            this.dataGridViewB.Name = "dataGridViewB";
            this.dataGridViewB.RowHeadersWidth = 65;
            this.dataGridViewB.Size = new System.Drawing.Size(225, 165);
            this.dataGridViewB.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1034, 469);
            this.Controls.Add(this.dataGridViewB);
            this.Controls.Add(this.dataGridViewA);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBxSalida);
            this.Controls.Add(this.btnPonerB);
            this.Controls.Add(this.btnPonerA);
            this.Controls.Add(this.btnLeerMat);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1050, 508);
            this.MinimumSize = new System.Drawing.Size(1050, 508);
            this.Name = "Form1";
            this.Text = "PROYECTO - MATRICES";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxBm;
        private System.Windows.Forms.TextBox TxBn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTamano;
        private System.Windows.Forms.Button btnLeerMat;
        private System.Windows.Forms.Button btnPonerB;
        private System.Windows.Forms.Button btnPonerA;
        private System.Windows.Forms.ListBox LBxSalida;
        private System.Windows.Forms.Button btnSumaAB;
        private System.Windows.Forms.Button btnSumaElemA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRestaAB;
        private System.Windows.Forms.Button btnMayorA;
        private System.Windows.Forms.Button btnSumaB;
        private System.Windows.Forms.Button btnMultAB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtErrores;
        private System.Windows.Forms.DataGridView dataGridViewA;
        private System.Windows.Forms.DataGridView dataGridViewB;
    }
}

