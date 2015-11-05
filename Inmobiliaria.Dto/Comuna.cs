using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dto
{
    public class Comuna
    {
        public Comuna()
        {
            this.Propiedades = new List<Propiedad>();
        }
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Activo { get; set; }
        public IList<Propiedad> Propiedades { get; set; }
    }
}
