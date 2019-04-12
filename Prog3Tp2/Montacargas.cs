using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3Tp2
{
    class Montacargas:Equipo
    {
        public int idDeposito { get; set; }
       
        public string patente { get; set; }
        public string EncargadoMantenimiento { get; set; }
        public float pesoMax { get; set; }

    }
}
