using System;

namespace ListaExercicios01
{
    class Exercicio09
    {
        /*
            9) Faça um algoritmo que leia três notas de um aluno, calcule e escreva a
            média final deste aluno. Considerar que a média é ponderada e que o
            peso das notas é 2, 3 e 5. O cálculo final da média deve ser realizado de
            acordo com a fórmula abaixo:

            mediafinal = (n1 * 2 + n2 * 3 + n3 * 5) / 10
        */
        public static void executar()
        {
            //Declarar variáveis;
            float nota1, nota2, nota3;
            float mediaPonderada;

            //Lemos as 3 notas
            Console.Write(" - Digite a Nota 1: ");
            float.TryParse(Console.ReadLine(),out nota1);

            Console.Write(" - Digite a Nota 2: ");
            float.TryParse(Console.ReadLine(),out nota2);

            Console.Write(" - Digite a Nota 3: ");
            float.TryParse(Console.ReadLine(),out nota3);

            //Calculamos a média ponderada
            mediaPonderada = (nota1 * 2 + nota2 * 3 + nota3 * 5) / 10;

            //Imprimimos a média
            Console.WriteLine(" **** Média Final: " + Math.Round(mediaPonderada,2));
            

        }
    }
}