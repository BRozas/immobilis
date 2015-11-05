using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dto
{
    public class ConjuntoHabitacional
    {
        public ConjuntoHabitacional()
        {
            this.Propiedades = new List<Propiedad>();
        }
        public int ConjuntoHabitacionalId { get; set; }
        public int Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        public IList<Propiedad> Propiedades { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
