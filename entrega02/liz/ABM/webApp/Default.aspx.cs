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
    public partial class _Default : Page
    {
        String connectionString = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

            completarGrilla();

        }

        void completarGrilla()
        {


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "SELECT Id, DisplayName, Email, Password FROM SEG_Users";

                string query = "SELECT Id, DisplayName as Nombre, Email, Password, Active FROM SEG_Users";
                using (SqlDataAdapter sda = new SqlDataAdapter(query, connection))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }

            }
        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            
            Page.Response.Redirect("Contact.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button EditarButton = (Button)sender;
            int intID = Convert.ToInt32(EditarButton.CommandArgument);

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName.Equals("Editar"))
            {
                var idreal = (((DataTable)this.GridView1.DataSource).Rows[index]["Id"]);
                Page.Response.Redirect("Contact.aspx?ID=" + idreal.ToString());

            }
            else
            {
                //Borrar de una
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    //cmd.CommandText = "SELECT Id, DisplayName, Email, Password FROM SEG_Users";
                    var id = (((DataTable)this.GridView1.DataSource).Rows[index]["Id"]);


                    cmd.CommandText = "DELETE FROM SEG_Users WHERE Id= @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                }
               //completarGrilla();
            }

            
        }
    }
}