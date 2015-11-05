using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dto
{
    public class Pago
    {
        public int PagoId { get; set; }
        public string FormaPago { get; set; }
        public int Total { get; set; }
        public int ContratoId { get; set; }
        public Contrato Contrato { get; set; }
    }
}
