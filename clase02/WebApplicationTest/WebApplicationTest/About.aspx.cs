using MiLibreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationTest
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Empleado test = new Empleado();
            lblMensaje.Text = test.Nombre;

 
            lblTexto.Text = (Page.IsPostBack) ? "Esto es un postback" : "Esta es la primera que cargo la pagina";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "Chau me fui";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            var a = "";
        }
    }
}