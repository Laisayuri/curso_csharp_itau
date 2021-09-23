using System;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo meuCirculo = new Circulo();
            Console.WriteLine("Área do Círculo: " + meuCirculo.calcularArea(5));

            Circulo meuCirculo2 = new Circulo();
            Console.WriteLine("Área do Círculo: " + meuCirculo2.calcularArea(9));

        }
    }
}
