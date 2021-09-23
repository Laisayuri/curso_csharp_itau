﻿using System;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" ---- Escolha uma das opções abaixo:");
            Console.WriteLine(" - 1: Área de um Círculo");
            Console.WriteLine(" - 2: Área de um Quadrado");
            Console.WriteLine(" - 3: Área de um Retângulo");
            int.TryParse(Console.ReadLine(), out int opcao);

            switch(opcao)
            {
                case 1 :
                    Console.Write(" - Digite o raio do cículo: ");
                    int.TryParse(Console.ReadLine(), out int raio);
                    Circulo meuCirculo = new Circulo();
                    Console.WriteLine(" ** Área do Círculo: " + meuCirculo.calcularArea(raio));
                    break;
                case 2:
                    Console.Write(" - Digite o lado do quadrado: ");
                    double.TryParse(Console.ReadLine(), out double lado);
                    Quadrado quadrado1 = new Quadrado();
                    Console.WriteLine(" ** Área do Quadrado: " + quadrado1.calcularArea(lado));
                    break;
                case 3:
                    Console.Write(" - Digite a base do retângulo: ");
                    double.TryParse(Console.ReadLine(), out double baseR);
                    Console.Write(" - Digite a altura do retângulo: ");
                    double.TryParse(Console.ReadLine(), out double alturaR);
                    Retangulo retangulo1 = new Retangulo();
                    Console.WriteLine(" ** Área do Retângulo: " + retangulo1.calcularArea(baseR,alturaR));
                    break;
                default:
                    Console.WriteLine(" - Opção Inválida");
                    break;

            }

            /*
            Circulo meuCirculo = new Circulo();
            Console.WriteLine("Área do Círculo: " + meuCirculo.calcularArea(5));

            Circulo meuCirculo2 = new Circulo();
            Console.WriteLine("Área do Círculo: " + meuCirculo2.calcularArea(9));
            */
        }
    }
}
