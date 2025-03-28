using MySql.Data.MySqlClient;
using System;

namespace Practica04_Login
{
    internal class PokedexConexion
    {
        private string stringConexion;

        public PokedexConexion()
        {
            // Ajusta tu cadena de conexión
            stringConexion = "Server=localhost;Database=pokeDB;User ID=root;Password=;";
        }

        public MySqlConnection getConexion()
        {
            // Creamos y abrimos una conexión cada vez que se llama
            MySqlConnection conexion = new MySqlConnection(stringConexion);
            conexion.Open();
            return conexion;
        }
    }
}
