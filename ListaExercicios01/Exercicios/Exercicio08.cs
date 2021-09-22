using System;

namespace ListaExercicios01
{
    class Exercicio08
    {
        /*
            8) Uma revendedora de carros usados paga a seus funcionários vendedores
            um salário fixo por mês, mais uma comissão também fixa para cada carro
            vendido e mais 5% do valor das vendas por ele efetuadas. Escrever um
            algoritmo que leia o número de carros por ele vendidos, o valor total de
            suas vendas, o salário fixo e o valor que ele recebe por carro vendido.
            Calcule e escreva o salário final do vendedor.
        */
        public static void executar()
        {
            //Declaramos nossas variáveis
            double salarioFixo;
            double comissaoFixaCarro;
            double comissaoValorVendas;
            double comissaoVendedorFixaCarro;
            int totalCarrosVendidos;
            double valorTotalVendas;
            double salarioFinal;

            //Fazer a leitura dos dados
            Console.Write(" - Total de carros vendidos: ");
            int.TryParse(Console.ReadLine(),out totalCarrosVendidos);

            Console.Write(" - Valor total de vendas: R$ ");
            double.TryParse(Console.ReadLine(),out valorTotalVendas);

            Console.Write(" - Digite o salário fixo: R$ ");
            double.TryParse(Console.ReadLine(),out salarioFixo);

            Console.Write(" - Digite a comissão fixa por carro: R$ " );
            double.TryParse(Console.ReadLine(),out comissaoFixaCarro);

            //Fazemos os cálculos
            comissaoValorVendas = valorTotalVendas * ((double)5/100);
            comissaoVendedorFixaCarro = totalCarrosVendidos * comissaoFixaCarro;
            salarioFinal = salarioFixo + comissaoValorVendas + comissaoVendedorFixaCarro;

            //Imprimimos na tela para o usuário
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("- Salário Fixo: R$ " + salarioFixo);
            Console.WriteLine("- Total comissão carros vendidos R$ " + comissaoValorVendas);
            Console.WriteLine("- Total comissão fixa por carro vendido: R$ " + comissaoVendedorFixaCarro);
            Console.WriteLine("- Salário Final: R$ " + salarioFinal);
            Console.WriteLine("---------------------------------------------------------");
            



        }
    }
}