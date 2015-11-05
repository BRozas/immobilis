using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dto
{
    public class ServicioMantencion
    {
        public int ServicioMantencionId { get; set; }
        public string Nombre { get; set; }
        public int Valor { get; set; }
        public TiposMantencion TipoMantencion { get; set; }
        public int PropiedadId { get; set; }
        public Propiedad Propiedad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
