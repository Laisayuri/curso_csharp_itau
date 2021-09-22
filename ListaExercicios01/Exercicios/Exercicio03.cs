using System;

namespace ListaExercicios01
{
    class Exercicio03
    {
        /*
            3) Escreva um algoritmo para ler as dimensões de um retângulo (base e
               altura), calcular e escrever a área do retângulo
        */
        public static void executar()
        {
            int baseRetangulo, alturaRetangulo;

            Console.Write("Digite o valor da Base do Retângulo: ");
            if(int.TryParse(Console.ReadLine(), out baseRetangulo))
            {
                Console.Write("Digite o valor da Altura do Retângulo: ");
                if(int.TryParse(Console.ReadLine(), out alturaRetangulo))
                {
                    //Calculo a área do retangulo
                    int areaRetangulo = baseRetangulo * alturaRetangulo;
                    //Escrevo a área
                    Console.WriteLine(" --> Área do Retângulo: " + areaRetangulo);
                } else {
                    Console.WriteLine("Valor inválido para a altura.");
                }
            } else
            {
                Console.WriteLine("Valor inválido para a base.");
            }
            
        }
    }
}