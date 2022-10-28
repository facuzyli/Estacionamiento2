using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Excepciones
{
    public class CantHorasEX : Exception
    {
        public override string Message => "Las horas ingresadas son invalidas";
    }

    public class PatenteEX : Exception
    {
        public override string Message => "La patente ingresada es invalida";
    }
}
