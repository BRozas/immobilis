using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dto
{
    public class Convenio
    {
        public Convenio()
        {
            this.Contratos = new List<Contrato>();
        }
        public int ConvenioId { get; set; }
        public int ClienteId { get; set; }
        public string Descripcion { get; set; }
        public int PorcentajeDescuento { get; set; }
        public TiposEstadoEntidad Estado { get; set; }
        public IList<Contrato> Contratos { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
