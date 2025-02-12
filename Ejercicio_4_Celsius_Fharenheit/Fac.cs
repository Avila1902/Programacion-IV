using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4_Celsius_Fharenheit
{
    public partial class Fac: Form
    {
        public Fac()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double fharenheit = double.Parse(txtNumFh.Text);

            double celsius = (fharenheit - 32) * 5 / 9;

            txtAns.Text = celsius.ToString("0.00") + "°C";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
