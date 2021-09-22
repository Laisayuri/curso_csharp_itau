using System;

namespace ListaExercicios01
{
    class Exercicio05
    {
        /*
            5) Escreva um algoritmo para ler o número total de eleitores de um
            município, o número de votos brancos, nulos e válidos. Calcular e
            escrever o percentual que cada um representa em relação ao total de
            eleitores.
        */
        public static void executar()
        {
            //Declaro e inicio minhas variaveis
            int totalEleitores = 0;
            int votosBrancos = 0;
            int votosNulos = 0;
            int votosValidos = 0;

            double porcNulos = 0;

            //Fazemos a leitura dos dados
            Console.Write("- Digite o total de eleitores do municipio: ");
            int.TryParse(Console.ReadLine(), out totalEleitores);

            Console.Write(" - Digite o total de votos em Branco: ");
            int.TryParse(Console.ReadLine(),out votosBrancos);

            Console.Write(" - Digite o total de votos nulos: ");
            int.TryParse(Console.ReadLine(), out votosNulos);

            Console.Write(" - Digite o total de votos válidos: ");
            int.TryParse(Console.ReadLine(), out votosValidos);

            //Calcular e imprimir
            //Votos em Branco, calculados diretamente no WriteLine
            Console.WriteLine(" ** " + Math.Round(((double)votosBrancos/(double)totalEleitores)*100,2) + "% Votos em Brancos");

            //Votos Nulos, calculados em uma variável
            porcNulos = ((double)votosNulos/(double)totalEleitores)*100;
            Console.WriteLine(" ** " + Math.Round(porcNulos,2) + "% Votos Nulos.");

            //Votos Válidos
            double porcValidos = ((double)votosValidos/(double)totalEleitores)*100;
            Console.WriteLine(" ** " + Math.Round(porcValidos,2) + "% Votos Válidos");

            
        }
    }
}