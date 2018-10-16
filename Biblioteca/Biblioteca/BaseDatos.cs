using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class BaseDatos
    {
        MySqlConnection connection;

        public BaseDatos()
        {
            connection = new MySqlConnection("server=127.0.0.1; database=bdbiblioteca; Uid=root; pwd=;");
        }

        public void query(string query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
            }catch
            {
                //nada
            }
        }

        public bool login(string codigo, string password)
        {
            bool res = false;
            try
            {
                string query = "SELECT * FROM bibliotecarios WHERE codigo = " + codigo + " AND password =  " + password;
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
            }
            catch
            {
                //nada
            }
            return res;
        }

        public string[][] buscarLibros(string cadena)
        {
            string[][] res = null;
            try
            {
                string query = "SELECT * FROM libros WHERE titulo LIKE " + cadena + " OR autor LIKE " + cadena + " OR codigo LIKE " + cadena;
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
            }
            catch
            {
                //nada
            }
            return res;
        }
        public string[][] buscarTesis(string cadena)
        {
            string[][] res = null;
            try
            {
                string query = "SELECT * FROM libros WHERE titulo LIKE " + cadena + " OR autor LIKE " + cadena + " OR codigo LIKE " + cadena;
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
            }
            catch
            {
                //nada
            }
            return res;
        }
    }
}
