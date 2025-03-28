using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica04_Login
{
    internal class ConexionDB
    {
        private MySqlConnection conexion;
        private string server = "localhost";
        private string database = "miLogin";
        private string user = "root";
        private string pw = "";
        private string cadenaConexion;

        public ConexionDB()
        {
            // Se construye la cadena de conexión correctamente sin espacios innecesarios.
            cadenaConexion = $"Server={server};Database={database};User ID={user};Password={pw};";
            // Se instancia la conexión utilizando la cadena de conexión.
            conexion = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection getConexion()
        {
            // Verificamos si la conexión está cerrada, en ese caso se abre.
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public void cerrarConexion()
        {
            // Si la conexión está abierta, se cierra.
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}   