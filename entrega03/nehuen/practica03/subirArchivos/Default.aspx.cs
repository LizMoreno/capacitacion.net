using CsvHelper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace subirArchivos
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Visible = false;
            this.Label1.Visible = false;
            this.ListBox1.Visible = false;
            this.Button2.Visible = false;
            
            List<String> fallo = new List<String>();
            if (string.IsNullOrEmpty(FileUpload1.FileName))
                return;

            if (this.FileUpload1.HasFiles)
            {
                string fileName = Server.HtmlEncode(FileUpload1.FileName);

                // Get the extension of the uploaded file.
                string extension = System.IO.Path.GetExtension(fileName);
                if (extension!=".csv")
                {
                    this.Label1.Text = "El archivo debe ser .csv";
                    this.Label1.Visible = true;
                    return;
                }
            }
            this.FileUpload1.SaveAs(Server.MapPath("Files") + "//" + FileUpload1.FileName);

            String connectionString = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
            Boolean flag = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int i = 0;
                connection.Open();
                string csvData = File.ReadAllText(Server.MapPath("Files") + "//" + FileUpload1.FileName);
                foreach (string row in csvData.Split('\n'))
                {
                    List<String> lista = new List<String>();
                    if (!string.IsNullOrEmpty(row) )
                    {
                        foreach (string cell in row.Split(';'))
                        {
                            lista.Add(cell.ToString().Replace('"',' ').Trim());
                        }
                    }
                    
                    if (i > 0 && lista.Count>0)
                    {
                        flag = true;
                        try
                        {


                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = connection;
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "INSERT INTO Operaciones VALUES(@order_id ,@account , @symbol , @transact_time , @side ,@ord_type , @order_price , @order_size  , @exec_inst,@time_in_force ,@expire_date ,@stop_px , @last_cl_ord_id , @text , @exec_type ,@ord_status , @last_price , @last_qty , @avg_price , @cum_qty , @leaves_qty )";
                            cmd.Parameters.AddWithValue("@order_id", lista[0]);
                            cmd.Parameters.AddWithValue("@account", lista[1]);
                            cmd.Parameters.AddWithValue("@symbol ", lista[2]);
                            cmd.Parameters.AddWithValue("@transact_time ", lista[3]);
                            cmd.Parameters.AddWithValue("@side ", lista[4]);
                            cmd.Parameters.AddWithValue("@ord_type ", lista[5]);
                            cmd.Parameters.AddWithValue("@order_price ", lista[6]);
                            cmd.Parameters.AddWithValue("@order_size  ", lista[7]);
                            cmd.Parameters.AddWithValue("@exec_inst", lista[8]);
                            cmd.Parameters.AddWithValue("@time_in_force ", lista[9]);
                            cmd.Parameters.AddWithValue("@expire_date ", lista[10]);
                            cmd.Parameters.AddWithValue("@stop_px ", lista[11]);
                            cmd.Parameters.AddWithValue("@last_cl_ord_id", lista[12]);
                            cmd.Parameters.AddWithValue("@text ", lista[13]);
                            cmd.Parameters.AddWithValue("@exec_type ", lista[14]);
                            cmd.Parameters.AddWithValue("@ord_status ", lista[15]);
                            cmd.Parameters.AddWithValue("@last_price ", lista[16]);
                            cmd.Parameters.AddWithValue("@last_qty", lista[17]);
                            cmd.Parameters.AddWithValue("@avg_price ", lista[18]);
                            cmd.Parameters.AddWithValue("@cum_qty ", lista[19]);
                            cmd.Parameters.AddWithValue("@leaves_qty ", lista[20]);
                            cmd.ExecuteNonQuery();
                            
                        }

                        catch (System.Data.SqlClient.SqlException sql)
                        {
                            if (sql.Message.IndexOf("Violation of PRIMARY KEY constraint") != -1) {
                                //Esta duplicado, avisame que no pude procesar este registro.
                                fallo.Add(row);
                            }
                        }
                        catch (Exception ex)
                        {
                            this.Label1.Text = ex.Message;
                            this.Label1.Visible=true;
                            
                        }
                    }
                    i++;
                }
            }
            if (flag == false)
            {
                Label2.Text = "El archivo esta vacio";
                Label2.Visible = true;
            }
            else
            {
                ListBox1.Visible = true;
                Label2.Text = " Las siguientes filas no se pudieron procesar";
                Label2.Visible = true;
                this.Button2.Visible = true;
                foreach (String c in fallo)
                {
                    ListBox1.Items.Add(c);
                }
            }
        }

        public void crear()
        {
            String connectionString = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "CREATE TABLE PruebaOperaciones (order_id Varchar(50), account INT, symbol Varchar(50), transact_time Varchar(50), side Varchar(50), ord_type Varchar(50), order_price double, order_size int , exec_inst Varchar(50),time_in_force Varchar(50),expire_date datetime,stop_px Varchar(50), last_cl_ord_id Varchar(50), text Varchar(50), exec_type Varchar(50),ord_status Varchar(50), last_price double, last_qty int, avg_price double, cum_qty int, leaves_qty int); ";
                cmd.ExecuteNonQuery();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string sPath = Server.MapPath("Files")+"//log.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in ListBox1.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }
            SaveFile.Close();
            Response.ContentType = "text/plain";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.AddHeader("Content-Disposition",
            string.Format("attachment; filename = \"{0}\"", System.IO.Path.GetFileName(sPath)));
            Response.TransmitFile(Server.MapPath("~/Files/log.txt"));
            Response.End();

        }
    }
}