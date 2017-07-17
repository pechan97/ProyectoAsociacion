using Asociacion.DAO;
using Asociacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociacion.BO
{
   public class IngresoBO
    {
        private IngresoDAO idao;
        public IngresoBO()
        {
            idao = new IngresoDAO();
        }
        /// <summary>
        /// Método Que autentifica si existe el usuario y contraseña ingresada. 
        /// </summary>
        /// <param name="ingreso"></param> Recibe como parámetro un ingreso
        /// <returns></returns> Retorna el ingreso autentificado
        public Ingreso Autentificar(Ingreso ingreso)
        {
            return idao.Autentificar(ingreso);
        }
    }
}
