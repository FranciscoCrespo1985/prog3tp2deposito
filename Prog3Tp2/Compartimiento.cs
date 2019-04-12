using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3Tp2
{
    class Compartimiento
    {
      
        public int id { get; set; }
        //public bool alquilado { get; set; }
        //public DateTime FechaFinAlquiler { get; set; }
        public float precio { get; set; }
        public int idCliente { get; set; }
        public float largo  { get; set; }
        public float alto { get; set; }
        public float ancho{ get; set; }
        public int idPasillo { get; set; }
    }
}
