using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dto
{
    public class Contrato
    {
        public Contrato()
        {
            this.Pagos = new List<Pago>();
            this.Documentos = new List<DocumentoDigital>();
        }
        public int ContratoId { get; set; }
        public int PropiedadId { get; set; }
        public Propiedad Propiedad { get; set; }
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
        public int NotariaId { get; set; }
        public Notaria Notaria { get; set; }
        public int BancoId { get; set; }
        public Banco Banco { get; set; }
        public int ConservadorBienRaizId { get; set; }
        public ConservadorBienRaiz ConservadorBienRaiz { get; set; }
        public int ConvenioId { get; set; }
        public Convenio Convenio { get; set; }
        public IList<Pago> Pagos { get; set; }
        public IList<DocumentoDigital> Documentos { get; set; }
    }
}
