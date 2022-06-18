

namespace Cuadrilateros.modelos.cuadrilateros
{
    public abstract class Cuadrilatero
    {
        private Vertice a;
        private Vertice b;
        private Vertice c;
        private Vertice d;

        public Cuadrilatero(Vertice a, Vertice b, Vertice c, Vertice d) {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public Vertice A { 
            set { 
                a = value;
            }
            get {
                return a;
            } 
        }
        public Vertice B {
            set {
                b = value;
            }
            get {
                return b;
            } 
        }
        public Vertice C {
            set
            {
                c = value;
            }
            get
            {
                return c;
            }
        }
        public Vertice D {
            set
            {
                d= value;
            }
            get
            {
                return d;
            }
        }

        public abstract double calcularArea();

        /**
         * Esta fue otra alternativa
         */
        public double calcularAreaDeCualquierCuadrilatero() { 
            // Area mediante el determinante
            //             descen      ascen
            // verice1 ->  x1 y1   -   x1 y1
            //               \           /
            // verice2 ->  x2 y2   -   x2 y2
            //               \           /
            // verice3 ->  x3 y3   -   x3 y3
            //               \           /
            // verice4 ->  x4 y4   -   x4 y4
            //               \           /
            // verice1 ->  x1 y1   -   x1 y1

            double descendentes = (A.x * B.y) + (B.x * C.y) + (C.x * D.y) + (D.x * A.y);
            double ascendentes = (B.x * A.y) + (C.x * B.y) + (D.x * C.y) + (A.x * D.y);

            double preSusultado = 0.5 * (descendentes - ascendentes);

            return preSusultado > -1 ? preSusultado : preSusultado * -1;
        }

    }
}
