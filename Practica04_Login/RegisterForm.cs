using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica04_Login
{
    public partial class RegisterForm : Form
    {
        private bool vShowPass = false;
        private ConexionDB mConexion;
        public RegisterForm()
        {
            InitializeComponent();
            mConexion = new ConexionDB();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLinkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 Login = new Form1();
            Login.Show();
            this.Hide();
        }

        private void pbViewPass1_Click(object sender, EventArgs e)
        {
            vShowPass = !vShowPass;

            if (vShowPass)
            {
                pbViewPass1.Image = Properties.Resources.invisible;
                txtPass1.PasswordChar = '\0';
                txtPassConfirm.PasswordChar = '\0';
            }
            else
            {
                txtPass1.PasswordChar = '*';
                txtPassConfirm.PasswordChar = '*';
                pbViewPass1.Image = Properties.Resources.boton_de_visibilidad;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Verificamos que la conexión se haya establecido
            if (mConexion.getConexion() != null)
            {
                //string result = "";
               MySqlCommand mySqlCommand = null;
               // MySqlDataReader mySqlDataReader = null;
                
                    // Se corrige la declaración de la consulta: se elimina la parte ", ConexionDB"
                    string consulta = "Insert Into miRegistro (Usuario, Contrasena) Values ('"+ txtUserRegister.Text.Trim() +"', '"+ txtPass1.Text.Trim() +"')";

                    mySqlCommand = new MySqlCommand(consulta, mConexion.getConexion());
                   

                    mySqlCommand.ExecuteNonQuery();

                    mConexion.cerrarConexion();



                if (txtPassConfirm.Text == txtPass1.Text)
                {
                    MessageBox.Show("Usuario registrado correctamente.");
                    // Abre el formulario de login
                    Form1 loginForm = new Form1();
                    loginForm.Show();

                    // Cierra el formulario de registro
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
        }

        }
    }
}
