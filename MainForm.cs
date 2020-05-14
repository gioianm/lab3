using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class MainForm : Form
    {
        private StateSpace SS1;
        public Matrix Y { get; set; }

        public MainForm()
        {
            SS1 = new StateSpace();

            InitializeComponent();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            int n;

            if (Int32.TryParse(OrderDETextBox.Text, out n))
            {
                for (int i = 0; i <= n; ++i)
                {
                    string cola = "a" + i.ToString();
                    dgvAkfs.Columns.Add(cola, cola);
                    dgvAkfs.Columns[cola].Width = 50;
                    string colb = "b" + i.ToString();
                    dgvBkfs.Columns.Add(colb, colb);
                    dgvBkfs.Columns[colb].Width = 50;
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SS1.U[0, 0] = 1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Y = SS1.calcStep();
            chart1.Series[0].Points.AddXY(SS1.Time, Y[0,0]);
        }

        private void FillGrid(Matrix M, DataGridView dgv)
        {
            for (int i = 0; i != M.M; ++i)
            {
                var colName = (i + 1).ToString();
                dgv.Columns.Add(colName, colName);
                dgv.Columns[colName].Width = 50;
            }
            for (int i = 0; i != M.N; ++i)
            {
                var colName = (i + 1).ToString();
                dgv.Rows.Add();
            }
            for (int i = 0; i != M.N; ++i)
            {
                for (int j = 0; j != M.M; ++j)
                {
                    dgv[j, i].Value = M[i, j];
                }
            }
        }

        private void calculateMatrixButton_Click(object sender, EventArgs e)
        {
            var n = dgvAkfs.Columns.Count;
            var a = new double[n];
            var b = new double[n];

            for (int i = 0; i != n; ++i)
            {
                a[i] = Double.Parse(dgvAkfs[i, 0].Value.ToString());
                b[i] = Double.Parse(dgvBkfs[i, 0].Value.ToString());
            }

            SS1.FromLineDE(a, b, 1);
            FillGrid(SS1.A, dgvA);
            FillGrid(SS1.B, dgvB);
            FillGrid(SS1.C, dgvC);
        }
    }
}
