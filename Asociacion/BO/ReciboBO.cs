using Asociacion.DAO;
using Asociacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociacion.BO
{
    public class ReciboBO
    {

        private ReciboDAO rdao;
        public ReciboBO()
        {
            rdao = new ReciboDAO();
        }

        /// <summary>
        /// Método que valora si no está en null los datos que no deben estarlo y registrar
        /// </summary>
        /// <param name="recibo"></param> Recibe un Recibo como parámetro
        public bool Registrar(Recibo recibo)
        {
            if (String.IsNullOrEmpty(recibo.Fecha))
            {
                throw new Exception("Seleccione la fecha");
            }
            if (String.IsNullOrEmpty(recibo.De))
            {
                throw new Exception("Es necesario de quien es el recibo");
            }
            if (String.IsNullOrEmpty(recibo.Monto.ToString()))
            {
                throw new Exception("El monto es requerido");
            }
            if (String.IsNullOrEmpty(recibo.Descripcion))
            {
                throw new Exception("El teléfono es requerido");
            }
            return rdao.Insertar(recibo);

        }
    }
}
