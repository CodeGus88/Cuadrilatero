

namespace Cuadrilateros.modelos.cuadrilateros
{
    internal class Trapecio : Cuadrilatero
    {

        /**
         * Los vertices forman la figura en sentido antihorario, empezando por a -> b -> c -> d (-> a)
         */
        public Trapecio(Vertice a, Vertice b, Vertice c, Vertice d): base(a, b, c, d) { 
             
        }

        public override double calcularArea() { 
            // Calcular los lados
            double la = Lados.distancia(A, B); // Lado A (base mayor)
            double lb = Lados.distancia(D, C); // Lado B (base menor)
            double lc = Lados.distancia(A, B); // Lado C
            double ld = Lados.distancia(C, B); // Lado D
            double f = (la + lb) / 2;
            // Cuadrados requeridos
            double lc2 = Math.Pow(lc, 2);
            double ld2 = Math.Pow(ld, 2);
            double g = (lc2 - ld2) + Math.Pow(la - lb, 2);
            double w = 2 * (la -lb);
            // area = f + √(lc2 - (g/w)^2)
            double area = f + Math.Sqrt((lc2 - Math.Pow( (g/w), 2) ));
            return area;
        }
    }
}
