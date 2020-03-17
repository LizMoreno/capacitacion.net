using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace webApp
{
    public partial class Contact : Page
    {
       
        String connectionString = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;


        bool EstamosAgregandoRegistroNuevo = false;


        String[] datos(string id)
        {
            String nombre;
            String email;
            String pass;
            String[] datos = new string[3];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT DisplayName as Nombre, Email, Password FROM SEG_Users where Id= @id";

                cmd.Parameters.AddWithValue("@id", id);
                     
               // cmd.ExecuteNonQuery(); //no devuelve resultados


                var reader = cmd.ExecuteReader(); //devuelve resultado
                while (reader.Read())
                {
                    nombre = reader.GetString(0);
                    datos[0] = nombre;
                    email = reader.GetString(1);
                    datos[1] = email;
                    pass = (String)reader.GetString(2);
                    datos[2] = pass;

                        
                }
            }
            return datos;

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(Page.Request.QueryString["ID"])) 
            {
               
                if (!Page.IsPostBack)
                {
                    lblEditar.Visible = true;
                    lblEditar.Enabled = true;
                    lblAgregar.Visible = false;
                    lblAgregar.Enabled = false;

                    String[] dato = new string[3];
                    dato = datos(Page.Request.QueryString["ID"]);
                    String nombre = dato[0];
                    String email = dato[1];
                    String pass = dato[2];
                    this.textNombre.Text = nombre;
                    this.TextEmail.Text = email;
                    this.TextPass.Text = pass; // No lo trae porque es tipo pass
                }

               
                EstamosAgregandoRegistroNuevo = false;
                
            } else
            {
                lblAgregar.Visible = true;
                lblAgregar.Enabled = true;
                lblEditar.Visible = false;
                lblEditar.Enabled = false;
                EstamosAgregandoRegistroNuevo = true;
                
            }
        }


        protected void IdAgregar_Click(object sender, EventArgs e)
        {

            if (EstamosAgregandoRegistroNuevo)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;

                    String nombre = this.textNombre.Text.ToString();
                    String email = this.TextEmail.Text.ToString();
                    String pass = this.TextPass.Text.ToString();

                    cmd.CommandText = "INSERT INTO SEG_Users VALUES (@DisplayName,@Email,@Password,@Active)";
                    cmd.Parameters.AddWithValue("@DisplayName", nombre);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", pass);
                    cmd.Parameters.AddWithValue("@Active", 1);
                    cmd.ExecuteNonQuery();
                }

                Page.Response.Redirect("Default.aspx");
            }
            else
            {

                //Update de base


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;


                    int id = Convert.ToInt32(Page.Request.QueryString["ID"]);
                    String nombre = this.textNombre.Text;
                    String email = this.TextEmail.Text;
                    String pass = this.TextPass.Text;


                    if (string.IsNullOrEmpty(pass))
                    {
                        cmd.CommandText = "UPDATE SEG_Users  SET DisplayName = @DisplayName, Email = @Email  WHERE Id =@id";

                    }
                    else
                    {
                        cmd.CommandText = "UPDATE SEG_Users  SET DisplayName = @DisplayName, Email = @Email, Password= @Password WHERE Id =@id";
                        cmd.Parameters.AddWithValue("@Password", pass);

                    }


                    cmd.Parameters.AddWithValue("@DisplayName", nombre);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }

                
            }
            Page.Response.Redirect("Default.aspx");
        }

        protected void IdAtras_Click(object sender, EventArgs e)
        {
           

            if (EstamosAgregandoRegistroNuevo)
            {
                Page.Response.Redirect("Default.aspx");
            }
            else
            {
                lblEditar.Enabled = true;
                String[] dato = new string[3];
                dato = datos(Page.Request.QueryString["ID"]);
                String nombre = dato[0];
                String email = dato[1];
                String pass = dato[2];
                this.textNombre.Text = nombre;
                this.TextEmail.Text = email;
                this.TextPass.Text = pass;
                Page.Response.Redirect("Default.aspx");
            }
        }
    }
}