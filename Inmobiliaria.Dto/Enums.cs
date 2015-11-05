using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Dto
{
    public enum TiposPropiedad
    {
        Departamento,
        Casa,
        bodega,
        Estacionamiento,
        Oficina
    }

    public enum TiposMantencion
    {
        RenovacionPintura,
        LavadoAlfombra,
        LimpiezaBano,
        CambioIluminarias
    }

    public enum TiposPersonas
    {
        Natural,
        Juridica
    }

    public enum TiposEstadoEntidad
    {
        Deshabilitado,
        Habilitado
    }
}
