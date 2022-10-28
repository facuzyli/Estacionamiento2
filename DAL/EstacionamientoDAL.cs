using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EstacionamientoDAL
    {
        public void Crear(Estacionamiento Datos)
        {
            SqlConnection miConexion = new SqlConnection(@"Data Source=(localdb)\Servidor;Initial Catalog=estacionamiento;Integrated Security=True");

            try
            {
                miConexion.Open();

                SqlCommand miComando = new SqlCommand("INSERT INTO Estacionamiento (Patente, Marca, Modelo, Color, Nombre, CantHoras, FechaRegistro)" +
                "VALUES (@Patente, @Marca, @Modelo, @Color, @Nombre, @CantHoras, @FechaRegistro)", miConexion);

                miComando.CommandType = CommandType.Text;

                miComando.Parameters.AddWithValue("Patente", Datos.Patentee);
                miComando.Parameters.AddWithValue("Marca", Datos.Marca);
                miComando.Parameters.AddWithValue("Modelo", Datos.Modelo);
                miComando.Parameters.AddWithValue("Color", Datos.Color);
                miComando.Parameters.AddWithValue("Nombre", Datos.Nombre);
                miComando.Parameters.AddWithValue("CantHoras", Datos.CantHoras);

                if (Datos.Fecha.HasValue)
                {
                    miComando.Parameters.AddWithValue("FechaRegistro", Datos.Fecha);
                }
                else
                {
                    miComando.Parameters.AddWithValue("FechaRegistro", DBNull.Value);
                }

                miComando.ExecuteNonQuery();



            }
            catch (Exception)
            {

                throw;
            }

            finally { miConexion.Close(); }
        }


    }
}
