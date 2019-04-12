using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3Tp2
{
    class Materiales:Compartimiento
    {
        public float maxMetrosCubicos { get; set; }
   
        public float metrosCubicosOcupado { get; set; }
        Producto material = new MaterialProd();

    }
}
