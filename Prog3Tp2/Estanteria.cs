using System.Collections.Generic;

namespace Prog3Tp2
{
    internal class Estanteria:Equipo
    {

        public int estantes { get; set; }
        public float metrosCubicosEstante { get; set; }
        public float pesoMaximo { get; set; }

        List<Producto> lProducto;



    }
}