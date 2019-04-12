using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3Tp2
{
 
    public class Deposito
    {
        public int id { get; set; }
        public string nombre { get; set; }
        List<Pasillo> pasillos = new List<Pasillo>();
        Direccion dir = new Direccion();
        public string telefono { get; set; }

        List<Equipo> lEquipos;



    }
}
