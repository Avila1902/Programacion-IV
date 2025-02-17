using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio_2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "admin" && txtPass.Text == "admin")
            {
                Form2 newform2 = new Form2();
                newform2.Show();
                
            }
            else
            {
                MessageBox.Show("El usuario o contraseña no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';  // Puedes usar cualquier carácter, por ejemplo: '•', '●'

        }
    }
}
