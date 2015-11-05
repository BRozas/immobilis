using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dto
{
    public class DocumentoDigital
    {
        public int DocumentoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public DateTime FechaSubida { get; set; }
        public int Tipo { get; set; }
        public string RutaVirtual { get; set; }
        public string UbicacionFisica { get; set; }
        public int ContratoId { get; set; }
        public Contrato Contrato { get; set; }
        public int TipoDocumentoDigitalId { get; set; }
        public TipoDocumentoDigital TipoDocumentoDigital { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
