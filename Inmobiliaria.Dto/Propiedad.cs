using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dto
{
    public class Propiedad
    {
        public Propiedad()
        {
            this.Contratos = new List<Contrato>();
            this.ServiciosDeMantenciones = new List<ServicioMantencion>();
        }
        public int PropiedadId { get; set; }
        public TiposPropiedad TipoPropiedad { get; set; }
        public string Direccion { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public int ComunaId { get; set; }
        public Comuna Comuna { get; set; }
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
        public int ConjuntoHabitacionalId { get; set; }
        public ConjuntoHabitacional ConjuntoHabitacional { get; set; }
        public IList<Contrato> Contratos { get; set; }
        public IList<ServicioMantencion> ServiciosDeMantenciones { get; set; }

    }
}
