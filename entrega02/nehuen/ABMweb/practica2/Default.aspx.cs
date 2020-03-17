using practica2.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practica2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Conexion con = new Conexion();
            List<Usuarios> user = null;
            user = con.consultaUsuarios();
            this.GridView1.DataSource = user;
            this.GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Alta.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Bajas.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Modificacion.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {



        }




        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

            var a = ((List<practica2.src.Usuarios>)GridView1.DataSource)[GridView1.Rows[e.NewEditIndex].DataItemIndex].idUsuario;
            Response.Redirect("Alta.aspx?ID=" + a);

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var a = ((List<practica2.src.Usuarios>)GridView1.DataSource)[GridView1.Rows[e.RowIndex].DataItemIndex].idUsuario;

            //var a = ((List<practica2.src.Usuarios>)GridView1.DataSource)[GridView1.Rows[e.NewEditIndex].DataItemIndex].idUsuario;
            Conexion c = new Conexion();
            c.baja(a);
            Response.Redirect("Default.aspx");
        }

        protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
        {

            /// ((Button)e.Row.Cells[5].Controls[0]).Attributes.Add("OnClick", "void(alert('pepito')");
            /// 
            var ctl = FindButton(e.Row, "Borrar");
            if (ctl!= null)
            {
              // ctl.Attributes.Add("OnClick", "return confirm('¿Eliminar este objeto?');");
                
            }

        }

        private Button FindButton(GridViewRow row, string text)
        {

            for (var index = 0; index < row.Cells.Count; index++)
            {
                foreach (var ctl in row.Cells[index].Controls)
                {
                    if (ctl is Button)
                    {
                        Button btn = (Button)ctl;
                        if (btn.Text.Equals(text))
                            return btn;
                    }
                }
            }

            return null;

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var a = "";
        }
    }
}