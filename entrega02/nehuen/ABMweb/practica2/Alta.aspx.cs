using practica2.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practica2
{
    public partial class Alta : Page
    {
        Boolean alta = true;
        string id = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.Request.QueryString.AllKeys.Contains("ID"))
            {
                if (!string.IsNullOrEmpty(Page.Request.QueryString["ID"]))
                {
                    id = Page.Request.QueryString["ID"];
                    alta = false;
                    if (!Page.IsPostBack)
                    {
                        Conexion c = new Conexion();
                        Usuarios u = c.Consulta(Convert.ToInt32(id));

                        if (u != null)
                        {
                            this.TextUser.Text = u.usuario.ToString();
                            this.TextMail.Text = u.email.ToString();

                            this.TextPass.Text = u.password.ToString();
                        }
                    }

                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {




        }


        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            var user = this.TextUser.Text.ToString();
            var em = this.TextMail.Text.ToString();
            var pass = this.TextPass.Text.ToString();
            if (user != null || em != null || pass != null)
            {
                if (email_bien_escrito(em))
                {
                    if (alta)
                    {
                        c.Alta(user, pass, em);
                    }
                    else
                    {
                        c.modificar(Convert.ToInt32(id), user, pass, em);
                    }

                    Response.Redirect("Completado.aspx");
                }
                
            }

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}