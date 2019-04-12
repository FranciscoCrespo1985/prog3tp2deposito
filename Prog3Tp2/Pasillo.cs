using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3Tp2
{
    class Pasillo
    {
 
        public int id { get; set; }
        public string nombre { get; set; }
        public int idDeposito { get; set; }

        List<Compartimiento> compartimiento = new List<Compartimiento>();

        public List<Camara> Camara{ get; set; }
                                           //List<Equipo> camara = new List<Equipo>();  
                  


    }
}
