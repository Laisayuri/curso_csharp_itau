using System;

namespace ListaExercicios01
{
    class Exercicio07
    {
        /*
            7) O custo de um carro novo ao consumidor é a soma do custo de fábrica
            com a porcentagem do distribuidor e dos impostos (aplicados ao custo de
            fábrica). Supondo que o percentual do distribuidor seja de 28% e os
            impostos de 45%, escrever um algoritmo para ler o custo de fábrica de um
            carro, calcular e escrever o custo final ao consumidor.
        */
        public static void executar()
        {
            //Declarar as variáveis que vamos utilizar
            double custoFabrica = 0;
            double custoFinalConsumidor = 0;
            double valorDistribuidor = 0;
            double valorImpostos;

            //Lemos o custo de fabrica do carro
            Console.Write(" - Digite o custo de fábrica do carro: ");
            double.TryParse(Console.ReadLine(), out custoFabrica);

            //Calcular os valores
            valorDistribuidor = custoFabrica * ((double)28/100);
            valorImpostos = custoFabrica * ((double)45/100);

            custoFinalConsumidor = custoFabrica + valorDistribuidor + valorImpostos;

            //Imprimimos na tela o valor
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-- Valor do Carro para o Consumidor: R$ "+ Math.Round(custoFinalConsumidor,2));
            Console.WriteLine("-- Impostos: R$ " + Math.Round(valorImpostos,2));
            Console.WriteLine("-- Distribuidor: R$ " + Math.Round(valorDistribuidor,2));
            Console.WriteLine("-- Custo Fábrica: R$ " + Math.Round(custoFabrica,2));

        }
    }
}