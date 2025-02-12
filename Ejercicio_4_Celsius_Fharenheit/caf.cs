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
    public partial class caf: Form
    {
        public caf()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double celsius = double.Parse(txtNumCels.Text);

            double fharenheit = (celsius * 9 / 5) + 32;

            txtAns.Text = fharenheit.ToString("0.00") + "°F";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
