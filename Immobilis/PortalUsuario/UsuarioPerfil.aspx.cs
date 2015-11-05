using Inmobiliaria.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PortalUsuario_UsuarioPerfil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
    }

    // The id parameter should match the DataKeyNames value set on the control
    // or be decorated with a value provider attribute, e.g. [QueryString]int id
    public Inmobiliaria.Dto.Persona fwNuevaPersona_GetItem()
    {
        try
        {
            using (FluentModel db = new FluentModel())
            {
                return db.Personas.Single(t => t.PersonaId == Convert.ToInt32(Session["PersonaId"].ToString()));
            }
        }
        catch (Exception)
        {
            //ModalStandart
            throw;
        }
    }

    // The id parameter name should match the DataKeyNames value set on the control
    public void fwNuevaPersona_UpdateItem(int PersonaId)
    {
        try
        {
            using (FluentModel db = new FluentModel())
            {
                Inmobiliaria.Dto.Persona usuario = db.Personas.Single(persona => persona.PersonaId == PersonaId);
                // Load the item here, e.g. item = MyDataLayer.Find(id);
                if (usuario == null)
                {
                    // The item wasn't found
                    ModelState.AddModelError("", String.Format("Item with id {0} was not found", PersonaId));
                    return;
                }
                TryUpdateModel(usuario);
                if (ModelState.IsValid)
                {
                    db.SaveChanges();
                }
                else
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                }
            }
        }
        catch (Exception ex)
        {

            throw;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (IsPostBack) return;
    }
}