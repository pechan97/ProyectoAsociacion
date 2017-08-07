using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociacion.Entidades
{
    public class Recibo
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string De { get; set; }
        public int Monto { get; set; }
        public string Descripcion { get; set; }
    }
}
