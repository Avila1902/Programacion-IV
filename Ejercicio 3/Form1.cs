using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1: Form
    {
        //Inicializamos Variables
        float vResultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(txtNum1.Text) + Convert.ToInt32(txtNum2.Text);
            lblResultado.Text = vResultado.ToString();
            lblsigno.Text = "+";
        }
        private void btnResta_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(txtNum1.Text) - Convert.ToInt32(txtNum2.Text);
            lblResultado.Text = vResultado.ToString();
            lblsigno.Text = "-";
        }
        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(txtNum1.Text) * Convert.ToInt32(txtNum2.Text);
            lblResultado.Text = vResultado.ToString();
            lblsigno.Text = "*";
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(txtNum1.Text) / Convert.ToInt32(txtNum2.Text);
            lblResultado.Text = vResultado.ToString();
            lblsigno.Text = "/";
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            lblResultado.Text = "000";
            lblsigno.Text = "□";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
