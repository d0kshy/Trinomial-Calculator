using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trinomial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double delta, x, x1, x2;

            if (!dataModel.InterpretA(tbA.Text))
            {
                MessageBox.Show("");
                return;
            }
            else if (!dataModel.InterpretB(tbB.Text))
            {
                MessageBox.Show("");
                return;
            }
            else if (!dataModel.InterpretC(tbC.Text))
            {
                MessageBox.Show("");
                return;
            }

            delta = dataModel.B * dataModel.B - 4 * dataModel.A * dataModel.C;

            if (delta > 0)
            {
                x1 = (-1) * dataModel.B + Math.Sqrt(delta) / 2 * dataModel.A;
                x2 = (-1) * dataModel.B - Math.Sqrt(delta) / 2 * dataModel.A;
                tbDisplay.Text = " " + dataModel.A + "x\u00B2 + " + dataModel.B + "x + " + dataModel.C + " = 0;" + 
                    "\r\n b\u00B2 - 4 * a * c = " + dataModel.B + "\u00B2" + " - 4 * " + dataModel.A + " * " + dataModel.C + " = " + delta +
                    ";\r\n Delta > 0. \r\n x\u2081 = -b + \u221Adelta / 2 * a = \r\n -" + dataModel.B + " + " + Math.Sqrt(delta) + " / 2 * " + dataModel.A + " = \r\n " + x1 +
                    ";\r\n x\u2082 = -b - \u221Adelta / 2 * a = \r\n -" + dataModel.B + " - " + Math.Sqrt(delta) + " / 2 * " + dataModel.A + " = \r\n " + x2 + ".";
            }
            else if (delta == 0)
            {
                x = (-1) * dataModel.B / 2 * dataModel.A;
                tbDisplay.Text = " " + dataModel.A + "x\u00B2 + " + dataModel.B + "x + " + dataModel.C + " = 0;" + "\r\n b\u00B2 - 4 * a * c = " + dataModel.B + "\u00B2" + " - 4 * " + dataModel.A + " * " + dataModel.C + " = " + delta +
                    ";\r\n Delta == 0. \r\n Only one root exists:  \r\n x = (-b) / 2 * a = (-" + dataModel.B + ") / 2 * " + dataModel.A + " = " + x + ".";
            }
            else
            {
                tbDisplay.Text = " " + dataModel.A + "x\u00B2 + " + dataModel.B + "x + " + dataModel.C + " = 0;" + "\r\n b\u00B2 - 4 * a * c = " + dataModel.B + "\u00B2" + " - 4 * " + dataModel.A + " * " + dataModel.C + " = " + delta + 
                    ";\r\n Delta < 0. \r\n Roots do not exist.";
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbC_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
