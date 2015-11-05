using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Session_LogOut : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        Session.Abandon();
        Session.Clear();
    }

    protected void btnSalirOk_Click(object sender, EventArgs e)
    {
        Response.Redirect(RutasFormularios.Home);
    }
}