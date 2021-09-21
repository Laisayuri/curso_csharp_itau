using System;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*AULA 01 - 20/09/2021*/

            int idadeAluno;
            string nomeAluno, sobrenomeAluno;
            bool validarIdade;
            DateTime dataNascimento;

            

            //TryParse - Tenta fazer uma conversao, se nao for correto ele retorna
            // False. Se for correta retorna o True e devolve o valor digitado
             
            /* 
            if(int.TryParse(Console.ReadLine(),out idadeAluno))
            {
                Console.WriteLine("Idade do aluno: " + idadeAluno);
            } else
            {
                Console.WriteLine(" *** Valor incorreto. ***");
            }
            */

            //Try Catch
            try
            {
                //Código
                Console.Write("Digite a Idade do Aluno: ");
                idadeAluno = int.Parse(Console.ReadLine());
                Console.WriteLine("A idade do aluno é: " + idadeAluno);
                dataNascimento = new DateTime(2000,12,25);
                int auxIdade = CalcularIdade(dataNascimento);

                Console.WriteLine("A idade calculada é: " + auxIdade);
            }
            catch(RankException ex)
            {
                //Controlar minha exception
                Console.WriteLine(" *** Erro no formato da idade ***");
            }   
            catch(FormatException ex)
            {
                //Controlar minha exception
                Console.WriteLine(" *** Erro no formato da idade ***");
            }   
            catch(Exception ex)
            {
                //Controle de erros
                Console.WriteLine(" *** Idade incorreta. ***");
                Console.WriteLine(ex.Message);
                
            }
                  
            

            

             

            
            

            /*
            Console.Write("Digite o nome do Aluno: ");
            nomeAluno = Console.ReadLine();

            Console.Write("Digite o sobrenome do Aluno: ");
            sobrenomeAluno = Console.ReadLine();

            Console.WriteLine("Nome completo do Aluno: " + nomeAluno + " " + sobrenomeAluno);
            */


            


            
            //idade = idade + 1; //37 int Console.Write

            //idade++; //Nesse caso adicionarei +1 a idade depois da leitura

            //++idade; //Nesee caso adicionarei +1 a idade antes da leitura

            /* 
                Operadores Matemáticos

                + -> Soma
                - -> Subtracao
                / -> Divisao
                * -> Multiplicacao

                % -> Resto

                && -> AND
                || -> OR
                != -> DIFERENTE
                == -> IGUAL

            /*
                Um bloco de comentario
                Tudo que estiver aqui será ignorado pelo compilador
            */

            //Exemplo IF
            /*
            if(idade%2==0)
            {
                Console.WriteLine("Número par");
            }
            else
            {
                Console.WriteLine("Número ímpar");
            }
            */

            //Exemplo FOR
            /*
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            */

            //Exemplo WHILE
            /*
            int x = 5;
            while(x > 0)
            {
                Console.WriteLine("X: " + x--);
            }
            */

            //Exemplo DO-WHILE
            /*
            int y = 5;
            do
            {
                Console.WriteLine("Y: " + y--);
            }while(y > 0);
            */

            

            
            
        }

        static int CalcularIdade(DateTime dataNascimento)
        {
            int idade = -1;

            idade = (DateTime.Today.Year - dataNascimento.Year);

            return idade;
        }
    }
}
