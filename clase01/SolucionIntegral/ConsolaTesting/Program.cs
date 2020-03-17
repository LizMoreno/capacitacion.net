using ClassLibrary1;
 
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            LeerUsuarios();

            string usario = System.Configuration.ConfigurationManager.AppSettings["pepe"];

            Console.WriteLine("el valor es {0} {1}", usario, ",");
            Console.WriteLine("Quien sos?");
            var sPerson = Console.ReadLine();
            IProgramador person = null;

            switch (sPerson.Trim().ToUpper())
            {
                case "NEHUEN":
                    person = new Nehuen();
                    break;
                case "LIZ":
                    person = new Liz();
                    break;  
            }

            person.Come();

            Console.ReadLine();
        }

        static void LeerUsuarios()
        {
            String connectionString = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Email FROM SEG_Users";

               
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var email = reader.GetString(0);
                    Console.WriteLine(email);
                }

                


            }


        }

      
    }
}
