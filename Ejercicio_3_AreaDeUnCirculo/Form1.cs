using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3_AreaDeUnCirculo
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
                double radio = Convert.ToDouble(txtVaIngresado.Text); // Obtener el radio ingresado
                double area = Math.PI * Math.Pow(radio, 2); // Calcular el área
            lblResultado.Text = "Area: " + area.ToString("F2");
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
             double radio = Convert.ToDouble(txtVaIngresado.Text); // Obtener el radio ingresado
             double perimetro = 2 * Math.PI * radio; // Calcular el perímetro
             MessageBox.Show("El perímetro del círculo es: " + perimetro.ToString("F2"), "Resultado");
            }
        }
    }

