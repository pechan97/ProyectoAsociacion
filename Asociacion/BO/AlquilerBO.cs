using Asociacion.DAO;
using Asociacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociacion.BO
{
    public class AlquilerBO
    {
        private AlquilerDAO adao;
        public AlquilerBO()
        {
            adao = new AlquilerDAO();
        }
        /// <summary>
        /// Método que valora si no está en null los datos que no deben estarlo
        /// </summary>
        /// <param name="alquiler"></param> Recibe un Participante como parámetro
        public bool Registrar(Alquiler alquiler)
        {
            if (String.IsNullOrEmpty(alquiler.Nombre))
            {
                throw new Exception("El Nombre es requerido");
            }
            if (String.IsNullOrEmpty(alquiler.Fecha))
            {
                throw new Exception("Seleccione la fecha");
            }
            if (String.IsNullOrEmpty(alquiler.Lugar))
            {
                throw new Exception("El lugar es requerido");
            }
            if (String.IsNullOrEmpty(alquiler.Telefono.ToString()))
            {
                throw new Exception("El teléfono es requerido");
            }
            if (String.IsNullOrEmpty(alquiler.Total.ToString()))
            {
                throw new Exception("El total es requerido");
            }
            return adao.Insertar(alquiler);

        }
    }
}
