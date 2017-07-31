using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociacion.Entidades
{
    public class Alquiler
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public string Lugar { get; set; }
        public int Telefono { get; set; }
        public int Mesas { get; set; }
        public int Sillas { get; set; }
        public int Manteles { get; set; }
        public int Lasos { get; set; }
        public int Cobertores { get; set; }
        public int SobreMantel { get; set; }
        public int SillasVerdes { get; set; }
        public int SillasBlancas { get; set; }
        public int Total { get; set; }
    }
}
