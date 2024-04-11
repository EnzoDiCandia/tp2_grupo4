using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp2_grupo4
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_volver5_Click(object sender, EventArgs e)
        {
            Response.Redirect("00-Portada.aspx");
        }
    }
}