using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dto
{
    public class Perfil
    {
        public Perfil()
        {
            this.Personas = new List<Persona>();
        }
        public int PerfilId { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public DateTime Creado { get; set; }
        public DateTime Modificado { get; set; }
        public IList<Persona> Personas { get; set; }
    }
}
