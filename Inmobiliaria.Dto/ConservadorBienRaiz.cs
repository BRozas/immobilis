using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dto
{
    public class ConservadorBienRaiz
    {
        public ConservadorBienRaiz()
        {
            this.Contratos = new List<Contrato>();
        }
        public int ConservadorBienRaizId { get; set; }
        public string Nombre { get; set; }
        public TiposEstadoEntidad Estado { get; set; }
        public IList<Contrato> Contratos { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
