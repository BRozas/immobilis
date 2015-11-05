using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dto
{
    public class Banco
    {
        public Banco()
        {
            this.Contratos = new List<Contrato>();
        }
        public int BancoId { get; set; }
        public int Nombre { get; set; }
        public IList<Contrato> Contratos { get; set; }
    }
}
