using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dto
{
    public class TipoDocumentoDigital
    {
        public TipoDocumentoDigital()
        {
            this.DocumentosDigitales = new List<DocumentoDigital>();
        }
        public int TipoDocumentoDigitalId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public TiposEstadoEntidad Estado { get; set; }
        public IList<DocumentoDigital> DocumentosDigitales { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
