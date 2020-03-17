using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace practica2.src
{
    public class Conexion
    {

        public List<Usuarios> consultaUsuarios()
        {
            List<Usuarios> resultado = new List<Usuarios>();
            String connectionString = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Id, DisplayName, Email, Password FROM SEG_Users";

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var id = reader.GetInt64(0);
                   
                    Usuarios c = new Usuarios(Convert.ToInt32(id), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    resultado.Add(c);
                }
            }
            
            return resultado;
        }
        public void Alta(String usuario, String contraseña, String email)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO SEG_Users VALUES (@DisplayName,@Email,@Password,@Active)";
                cmd.Parameters.AddWithValue("@DisplayName", usuario);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", contraseña);
                cmd.Parameters.AddWithValue("@Active", 1);
                cmd.ExecuteNonQuery();
            }
        }



        public void modificar(int id,String usuario, String contraseña, String email)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update SEG_Users set DisplayName = @usuario, Email= @email, Password=@pass WHERE Id=@id";
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pass", contraseña);
                cmd.Parameters.AddWithValue("@id", id.ToString());
                cmd.ExecuteNonQuery();
            }
        }





        public Usuarios Consulta(int id)
        {
            Usuarios c = null;
            String connectionString = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Id, DisplayName, Email, Password FROM SEG_Users WHERE Id=@id" ;
                cmd.Parameters.AddWithValue("id", id.ToString());
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var i = reader.GetInt64(0);
                    c = new Usuarios(Convert.ToInt32(i), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                }
                
            }
            return c;
        }

        public Usuarios baja(int id)
        {
            Usuarios c = null;
            String connectionString = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM SEG_Users WHERE Id=@id";
                cmd.Parameters.AddWithValue("id", id.ToString());
                cmd.ExecuteNonQuery();


            }
            return c;
        }


    }
}