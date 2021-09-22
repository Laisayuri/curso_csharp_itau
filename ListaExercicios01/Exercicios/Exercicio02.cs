using System;

namespace ListaExercicios01
{
    class Exercicio02
    {
        /*
            2)  Escreva um algoritmo para ler um valor (do teclado) e escrever (na tela)
                o seu antecessor
        */

        public static void executar()
        {
            int valor;

            //Validação TryParse
            Console.Write("Digite um valor: ");
            if(int.TryParse(Console.ReadLine(), out valor))
            {
                //Guardo o valor anterior
                --valor;

                Console.WriteLine(" Valor: " + valor);
            }else{
                Console.WriteLine(" ** Valor inválido.");
            }

        }
    }
}