using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.modelos
{

    
    public class Vertice
    {
        public double x { set; get; }
        public double y { set; get; }

        public Vertice(double x, double y)
        {
            this.x = x; this.y = y;
        }

    }
}
