// Uso de los cuadriláteros

using Cuadrilateros.modelos;
using Cuadrilateros.modelos.cuadrilateros;


do {
    Console.WriteLine("Elija una opción\n\n" +
        "1. Calcular el área de un Cuadrado\n" +
        "2. Calcular el área de un Rectangulo\n" +
        "3. Calcular el área de un Trapecio\n");
    String opcionSeleccionada = Console.ReadLine();
    switch (opcionSeleccionada) {
        case "1":
            Vertice [] listaOp1 = obtenerVectoresCuadrilátero();
            Cuadrado cuadrado = new Cuadrado(listaOp1[0], listaOp1[1], listaOp1[2], listaOp1[3]);
            Console.Write($"El área del cuadrado es: {cuadrado.calcularArea()}\n");
            break;
        case "2":
            Vertice[] listaOp2 = obtenerVectoresCuadrilátero();
            Rectangulo rectangulo = new Rectangulo(listaOp2[0], listaOp2[1], listaOp2[2], listaOp2[3]);
            Console.Write($"El área del rectángulo es: {rectangulo.calcularArea()}\n");
            break;
        case "3":
            Vertice[] listaOp3 = obtenerVectoresCuadrilátero();
            Rectangulo trapecio = new Rectangulo(listaOp3[0], listaOp3[1], listaOp3[2], listaOp3[3]);
            Console.Write($"El área del trapecio es: {trapecio.calcularArea()}\n");
            break;
        default:
            Console.WriteLine("Opción inválida...");
            break;

    }
    Console.WriteLine("Presiona cualquier tecla para continuar, \"S\" para salir");
} while (Console.ReadKey().Key != ConsoleKey.S);


Vertice [] obtenerVectoresCuadrilátero() { 
    Vertice[] vertices = new Vertice[4];
    Console.WriteLine("Ingrese los vertices en sentido antiorario:\n");
    for (int i = 1; i <= 4; i++) {
        double x = 0;
        double y = 0;
        Console.Write($"Verice {i} posición x: ");
        double.TryParse(Console.ReadLine(), out x);
        Console.Write($"Verice {i} posición y: ");
        double.TryParse(Console.ReadLine(), out y);
        vertices[i-1] = new Vertice(x, y);
        Console.WriteLine();
    }
    return vertices;
}