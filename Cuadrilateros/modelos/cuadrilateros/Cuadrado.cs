

namespace Cuadrilateros.modelos.cuadrilateros
{
    public class Cuadrado : Cuadrilatero
    {
        public Cuadrado(Vertice a, Vertice b, Vertice c, Vertice d) 
            : base(a, b, c, d)
        {

        }

        public override double calcularArea() {   
            // areaCuadrado = (cualquierLado)^2;
            return Math.Pow(Lados.distancia(A, B), 2);
        }
    }
}
