using DAL;
using Entidades;
using Negocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EstacionamientoBLL
    {
        EstacionamientoDAL miestacionamientoDAL = new EstacionamientoDAL();
        public void Crear(Estacionamiento Datos)
        {


            try
            {
                if (Datos.Patentee.Length == 6 || Datos.Patentee.Length == 7)
                {
                    if (Datos.CantHoras > 0 && Datos.CantHoras < 25)
                    {
                        miestacionamientoDAL.Crear(Datos);
                    }
                    else
                    {
                        throw new CantHorasEX();
                    }
                }
                else
                {
                    throw new PatenteEX();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }







        }
    }
}
