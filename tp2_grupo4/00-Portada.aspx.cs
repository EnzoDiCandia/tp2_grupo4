using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp2_grupo4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ej 1.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ej 2.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ej 3.aspx");
        }

        protected void Btn_ej4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ej 4.aspx");
        }

        protected void Btn_ej5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ej 5.aspx");
        }
    }
}