using Inmobiliaria.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Wuc_HomeLogin : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        panelLogInModal.Visible = true;
        panelSession.Visible = false;
    }

    protected void btnLoginHome_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(this.txtContrasena.Text.Trim()) || String.IsNullOrEmpty(this.txtEmail.Text.Trim()))
            return;
        using (FluentModel db = new FluentModel())
        {
            if (db.Personas.Any(t => t.Contrasena == this.txtContrasena.Text.Trim() && t.Email == this.txtEmail.Text.Trim()))
            {
                Persona usuario = db.Personas.Single(t => t.Contrasena == this.txtContrasena.Text.Trim() && t.Email == this.txtEmail.Text.Trim());
                Session.Add("PersonaId", usuario.PersonaId);
                Session.Add("Nombre", usuario.Nombre);
                Session.Add("Apellido", usuario.Apellido);
                Session.Add("Rut", usuario.Rut);
                Session.Add("TipoPersona", usuario.TipoPersona);
                Session.Add("NombreUsuario", usuario.NombreUsuario);
                Session.Add("Contrasena", usuario.Contrasena);
                Session.Add("Email", usuario.Email);
                Session.Add("Telefono", usuario.Telefono);
                panelLogInModal.Visible = false;
                panelSession.Visible = true;
            }
            Response.Redirect(RutasFormularios.UsuarioInicio);
        }
    }
}