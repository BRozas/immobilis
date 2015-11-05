using Inmobiliaria.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Masters_Portal : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["PersonaId"] != null && !String.IsNullOrEmpty(Session["PersonaId"].ToString()))
        {
            litNombreUsuario.Text = Session["NombreUsuario"].ToString();
            panelMenuLogin.Visible = false;
            panelSessionActiva.Visible = true;
        }
        else
        {
            panelMenuLogin.Visible = true;
            panelSessionActiva.Visible = false;
        }
    }

    //protected void btnLoginHome_Click(object sender, EventArgs e)
    //{
    //    if (String.IsNullOrEmpty(this.txtContrasena.Text.Trim()) || String.IsNullOrEmpty(this.txtEmail.Text.Trim()))
    //        return;
    //    using (FluentModel db = new FluentModel())
    //    {
    //        if (db.Personas.Any(t => t.Contrasena == this.txtContrasena.Text.Trim() && t.Email == this.txtEmail.Text.Trim()))
    //        {
    //            this.litNombreUsuarioLogeado.Text = db.Personas.Single(t => t.Contrasena == this.txtContrasena.Text.Trim() && t.Email == this.txtEmail.Text.Trim()).NombreUsuario.ToUpper();
    //            PanelMenuUsuarioLogeado.Visible = true;
    //            PanelMenuLogin.Visible = false;
    //        }
    //        else
    //        {
    //            PanelMenuUsuarioLogeado.Visible = false;
    //            PanelMenuLogin.Visible = true;
    //        }
    //    }
    //}

    protected void lbLinkMenuUsuarioPerfil_Click(object sender, EventArgs e)
    {
        Response.Redirect(RutasFormularios.UsuarioInicio);
    }
}

