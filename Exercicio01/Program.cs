using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Calcular a idade da pessoa, lendo uma data fornecida
                pelo usuario.
            */

            //Variaveis

            
            DateTime dataNascimento;
            int idade = 0;
            
            
            //Primeiro temos que ler a data de nascimento
            Console.Write("Digite uma data de nascimento: ");
            if(DateTime.TryParse(Console.ReadLine(), out dataNascimento))
            {
                //idade = DateTime.Today.Year - dataNascimento.Year;
                if(DateTime.Today.DayOfYear < dataNascimento.DayOfYear)
                {
                    idade = DateTime.Today.Year - dataNascimento.Year - 1;
                } else
                {
                    idade = DateTime.Today.Year - dataNascimento.Year;
                }

            

                Console.WriteLine(" -- Idade: " + idade);
                Console.WriteLine(" -- Dia do Ano Hoje: " + DateTime.Today.DayOfYear);
                Console.WriteLine(" -- Dia do Ano do Aniversario do Jose: " + dataNascimento.DayOfYear);
                DayOfWeek diaSemana = DateTime.Today.DayOfWeek;
                
                


            } else
            {
                Console.WriteLine("Formato de data inválido");
            }
            
            

        }
    }
}
