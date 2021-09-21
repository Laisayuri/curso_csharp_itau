using System;

namespace ListaExercicios01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** LISTA DE EXERCÍCIOS 01 ***");
            int opcao = 0;

            //Do While para que o programa execute até que seja digitado 99
            do
            {
                //Mensagem para o usuario digitar o número do exercício
                Console.Write(" Digite o número do exercício (99 - para sair): ");
                //Captura e conversão a inteiro da opção digitada
                int.TryParse(Console.ReadLine(), out opcao);

                switch(opcao)
                {
                    case 1:
                        Exercicio01.executar();
                        break;
                    case 2:
                        //To-Do Exercicio 2
                        break;
                    case 99:
                        Console.WriteLine(" * Saindo do programa");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            }while(opcao != 99);
        }
    }
}
