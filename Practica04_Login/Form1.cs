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
    public partial class Form1 : Form
    {
        private bool vShowPass = false;
        private ConexionDB mConexion;


        public Form1()
        {
            InitializeComponent();
            mConexion = new ConexionDB();
            this.AcceptButton = this.btnLogin;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm Register = new RegisterForm();
            Register.Show();
            this.Hide();
        }

        private void txtUserLogin_Enter(object sender, EventArgs e)
        {
            if (txtUserLogin.Text == "example@domain.com")
            {
                txtUserLogin.Text = "";
                txtUserLogin.ForeColor = Color.Black;
            }
        }

        private void txtUserLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserLogin.Text))
            {
                txtUserLogin.Text = "example@domain.com";
                txtUserLogin.ForeColor = Color.Gray;
            }
        }

        private void pbViewPass_Click(object sender, EventArgs e)
        {
            vShowPass = !vShowPass;

            if (vShowPass)
            {
                txtUserPass.PasswordChar = '\0';
                pbViewPass.Image = Properties.Resources.invisible;
            }
            else
            {
                txtUserPass.PasswordChar = '*';
                pbViewPass.Image = Properties.Resources.boton_de_visibilidad;
            }
        }

        private void txtUserPass_TextChanged(object sender, EventArgs e)
        {
            // Puedes agregar validaciones en tiempo real si lo deseas
        }

        private void txtUserLogin_TextChanged(object sender, EventArgs e)
        {
            // Puedes agregar validaciones en tiempo real si lo deseas
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Verificamos que la conexión se haya establecido
            if (mConexion.getConexion() != null)
            {
                string result = "";
                MySqlCommand mySqlCommand = null;
                MySqlDataReader mySqlDataReader = null;
                try
                {
                    // Se corrige la declaración de la consulta: se elimina la parte ", ConexionDB"
                    string consulta = "SELECT IDUser, Usuario, Contrasena FROM miRegistro WHERE Usuario = @vUsuario AND Contrasena = @vContrasena";

                    mySqlCommand = new MySqlCommand(consulta, mConexion.getConexion());
                    mySqlCommand.Parameters.AddWithValue("@vUsuario", txtUserLogin.Text.Trim());
                    mySqlCommand.Parameters.AddWithValue("@vContrasena", txtUserPass.Text.Trim());

                    mySqlDataReader = mySqlCommand.ExecuteReader();

                    if (mySqlDataReader.HasRows) // Si hay resultados, la autenticación es correcta
                    {
                        
                        pokedex pokedex = new pokedex();
                        pokedex.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Cerramos el DataReader si no es nulo
                    if (mySqlDataReader != null)
                        mySqlDataReader.Close();
                    // Cerramos la conexión a la base de datos
                    mConexion.cerrarConexion();
                }
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }
        }
    }
}
