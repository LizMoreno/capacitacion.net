using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace subirArchivos
{
    public partial class Contact : Page
    {
        String connectionString = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            RepeterData();
        }

        public void RepeterData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                //cmd = new SqlCommand("Select * from Operaciones", connection);

                string query = "select * from Operaciones order by transact_time asc";

                using (SqlDataAdapter sda = new SqlDataAdapter(query, connection))
                {

                    using (DataSet ds = new DataSet())
                    {
                        sda.Fill(ds);
                        RepterDetails.DataSource = ds;
                        RepterDetails.DataBind();
                    }
                }
            }
        }
    }
}