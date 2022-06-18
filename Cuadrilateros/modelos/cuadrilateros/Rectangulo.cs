

namespace Cuadrilateros.modelos.cuadrilateros
{
    internal class Rectangulo: Cuadrilatero
    {  public Rectangulo(Vertice a, Vertice b, Vertice c, Vertice d)
            : base(a, b, c, d)
        {

        }

        public override double calcularArea() {
            // areaRectangulo = base * altura;
            return (Lados.distancia(A, B) * Lados.distancia(B, C));
        }
    }
}
