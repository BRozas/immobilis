using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dto
{
    public class Notaria
    {
        public Notaria()
        {
            this.Contratos = new List<Contrato>();
        }
        public int NotariaId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public IList<Contrato> Contratos { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
