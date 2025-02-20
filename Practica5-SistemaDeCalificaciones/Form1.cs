using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Practica5_SistemaDeCalificaciones
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNote1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            double note1, note2, note3, average;

            // Validar que sean números y que no estén vacíos
            if (double.TryParse(txtNote1.Text, out note1) &&
                double.TryParse(txtNote2.Text, out note2) &&
                double.TryParse(txtNote3.Text, out note3))
            {

                // Asegurar que estén en el rango de 10 a 100
                if (note1 < 10 || note1 > 100 || note2 < 10 || note2 > 100 || note3 < 10 || note3 > 100)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("Las calificaciones deben estar en un rango de 10 a 100", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Calcular promedio
                average = (note1 + note2 + note3) / 3;

                //Mostrar promedio en el label con dos decimales
                lblPromedio.Text = "Promedio: " + average.ToString("0.00");

                // Mostrar PictureBox
                pbResultado.Visible = true;

                // Determinar el estatus y cambiar color del label e imagen
                if (average >= 95)  
                {
                    lblStatus.Text = "Estatus: Exento"; // Si el promedio es 95 o más
                    lblStatus.ForeColor = Color.Green;
                    pbResultado.Image = Image.FromFile("Resources/exento1.png"); // Ruta de la imagen
                }
                else if (average >= 70)
                {
                    lblStatus.Text = "Estatus: Ordinario";  // Si el promedio está entre 70 y 94
                    lblStatus.ForeColor = Color.Blue;
                    pbResultado.Image = Image.FromFile("Resources/ordinario.png"); // Ruta de la imagen
                }
                else if (average >= 50)
                {
                    timer1.Start(); // Iniciar el timer para que el label parpadee
                    lblStatus.Text = "Estatus: Extraordinario";  // Si el promedio está entre 50 y 69
                    lblStatus.ForeColor = Color.Orange;
                    pbResultado.Image = Image.FromFile("Resources/extra.png"); // Ruta de la imagen
                }
                else if (average < 50)
                {
                    timer1.Start(); // Iniciar el timer para que el label parpadee
                    lblStatus.Text = "Estatus: Especial"; // Si el promedio es menor a 50
                    lblStatus.ForeColor = Color.Red;
                    pbResultado.Image = Image.FromFile("Resources/especial.png"); // Ruta de la imagen
                }
            }
            else 
            {
                // Si no son números, mostrar mensaje de error
                MessageBox.Show("Ingrese solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para cerrar la aplicación cuando se presiona el botón de cerrar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Limpiar los campos de texto y labels
        private void button2_Click(object sender, EventArgs e)
        {
            txtNote1.Text = "";
            txtNote2.Text = "";
            txtNote3.Text = "";
            lblPromedio.Text = "Promedio: ";
            lblStatus.Text = "Estatus: ";
            lblStatus.ForeColor = Color.Black;
            pbResultado.Visible = false; // Ocultar PictureBox
        }

        private void txtNote1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números, la tecla de retroceso y el punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Evita que haya más de un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblStatus.ForeColor == Color.Red || lblStatus.ForeColor == Color.Orange)
            {
                lblStatus.Visible = !lblStatus.Visible; // Hace que el label parpadee
            }
        }

       
    }
}
