using EjercicioPolimorfismo;

class Program
{
    static void Main(string[] args)
    {
        Figura figuraRectangulo = new Rectangulo();
        Figura figuraTriangulo = new Triangulo();

        figuraRectangulo.CalcularArea(); // Llama al método de Rectangulo
        figuraTriangulo.CalcularArea(); // Llama al método de Triangulo
    }
}