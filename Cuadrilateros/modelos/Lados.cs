using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.modelos
{
    public class Lados
    {

        public static double distancia(Vertice punto1, Vertice punto2) {
            // distancia = |[(x2 - x1) + (y2 - y1)]^(1/2)|
            double distancia = Math.Sqrt(
                Math.Pow((punto2.x - punto1.x), 2) +
                Math.Pow((punto2.y - punto1.y), 2)
                );
            return distancia > -1 ? distancia : distancia * -1;
        }

    }
}
