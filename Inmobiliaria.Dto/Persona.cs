using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dto
{
    public class Persona
    {
        public Persona()
        {
            this.Propiedades = new List<Propiedad>();
            this.Contratos = new List<Contrato>();
        }
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Rut { get; set; }
        public TiposPersonas TipoPersona { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public Perfil Perfil { get; set; }
        public IList<Propiedad> Propiedades { get; set; }
        public IList<Contrato> Contratos { get; set; }
    }
}
