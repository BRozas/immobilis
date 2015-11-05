using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dto
{
    public class Usuario
    {
        public int Id { get; set; }
        public Persona Persona { get; set; }
        public int PersonaId { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
    }
}
