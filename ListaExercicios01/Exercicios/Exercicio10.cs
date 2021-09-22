using System;

namespace ListaExercicios01
{
    class Exercicio10
    {
        /*
            10)Escreva um algoritmo para ler uma temperatura em graus Fahrenheit,
            calcular e escrever o valor correspondente em graus Celsius,
            considerando a fórmula abaixo. 

            C / 5 = F - 32 / 9   

        */
        public static void executar()
        {
            //Variáveis
            float temperaturaF;
            float temperaturaC;

            //Leitura da temperatura
            Console.Write(" - Digite a temperatura em Fahrenheit: ");
            float.TryParse(Console.ReadLine().Replace(".",",").Replace(";",","),out temperaturaF);

            //Calculamos a temperatura em Celsius
            temperaturaC = (temperaturaF - 32) * ((float)5/9);

            //Imprimimos a temperatura
            Console.WriteLine(" *** Temperatura em Celsius: " + Math.Round(temperaturaC,1)+ "°");


        }
    }
}