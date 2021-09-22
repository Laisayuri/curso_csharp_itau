using System;

namespace ListaExercicios01
{
    class Exercicio04
    {
        /*
            4) Faça um algoritmo que leia a idade de uma pessoa expressa em anos,
            meses e dias e escreva a idade dessa pessoa expressa apenas em dias.
            Considerar ano com 365 dias e mês com 30 dias
        */
        public static void executar()
        {
            //Declaro as minhas variáveis
            int dias = 0, meses = 0, anos = 0;
            bool validar;

            //Faço a leitura dos dados
            Console.Write("Digite quantos anos você tem: ");
            validar = int.TryParse(Console.ReadLine(), out anos);

            if(validar) //  !validar == false -- validar == true
            {
                //Solicito os meses e guardo a validação em validar
                Console.Write(" e quantos meses: ");
                validar = int.TryParse(Console.ReadLine(), out meses);
            }

            if(validar)
            {
                //Capturamos total de dias e validamos
                Console.Write(" e quantos dias: ");
                validar = int.TryParse(Console.ReadLine(),out dias);
            }

            //Uso a negação para o IF
            if(!validar)
            {
                Console.WriteLine("Valor inválido");
            } else
            {
                int resultado = (anos * 365) + (meses * 30) + dias;
                Console.WriteLine(" - Idade em dias: " + resultado);
            }

        }
    }
}