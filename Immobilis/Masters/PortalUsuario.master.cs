using Inmobiliaria.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Masters_PortalUsuario : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        try
        {
            using (FluentModel db = new FluentModel())
            {
                Persona usuario = db.Personas.Single(t => t.PersonaId == Convert.ToInt32(Session["PersonaId"].ToString()));
                NombreUsuarioSidebar.Text = usuario.Nombre + " " + usuario.Apellido;
                EmailDropMenu.Text = usuario.Email;
                //if(usuario.Perfil. == )
                //this.menuAdministrador.Visible = true;
            }
        }
        catch (Exception)
        {
            Response.Redirect("SessionCerrada.aspx");
        }
    }
}
