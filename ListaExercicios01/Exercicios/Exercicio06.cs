using System;

namespace ListaExercicios01
{
    /*
        6) Escreva um algoritmo para ler o salário mensal atual de um funcionário e
        o percentual de reajuste. Calcular e escrever o valor do novo salário.    
    */
    class Exercicio06
    {
        public static void executar()
        {
            //Declaramos as variáveis
            double salarioAtual = 0;
            double percentualReajuste = 0;
            double novoSalario = 0;

            //Leitura dos valores
            Console.Write(" - Digite o salário mensal atual: ");
            double.TryParse(Console.ReadLine(), out salarioAtual);

            Console.Write(" - Digite o percentual de reajuste: ");
            double.TryParse(Console.ReadLine(), out percentualReajuste);

            //Calculamos o novo salário
            novoSalario = salarioAtual + (percentualReajuste/100)*salarioAtual;

            //Imprimos o novo salário
            Console.WriteLine(" - O Novo salário é: R$ " + Math.Round(novoSalario,2));
        }
    }
}