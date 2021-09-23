using System;

namespace ExemploArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*********************************
                Array "Primitivo"
            /*********************************/
            int[] idades = new int[6];

            idades[0] = 20;
            idades[1] = 25;
            idades[2] = 87;
            idades[3] = 24;
            idades[4] = 14;
            idades[5] = 99;

            foreach(int i in idades)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*******");
            for(int x=0;x < 6;x++)
            {
                Console.WriteLine(idades[x]);
            }


            /*********************************
                Arrays Implícitos
            *********************************/
            //Exemplo de Array de Strings
            var nomes = new [] {"Rodrigo","Italo","Manoel","Antonio","Jose","Maria"};

            Console.WriteLine(nomes[4]);

            //Exemplo de Array de Inteiros
            var aux = new [] {1,2,3,4,5,6,7,8,9,10};

            //Arrays de tipo double
            var aux2 = new [] {1,2,3,4,5,6,7,8.0,9.0,10.0};
            var aux3 = new [] {1,2,3,4,5,6,7,8.0,9.0,10.0};
            var aux5 = new [] {1.0,2.0,3.0};

            /*********************************
                Arrays de Objetos
            /*********************************/

            Funcionarios[] arrayFuncionarios = new Funcionarios[2];
            Funcionarios func1 = new Funcionarios("Jose","Da Silva",123,"31 3332-1231");
            Funcionarios func2 = new Funcionarios("Maria","Alves",98721221,"11 99800-1231");

            arrayFuncionarios[0] = func1;
            arrayFuncionarios[1] = func2;
            Console.WriteLine("*****************************");
            foreach(Funcionarios func in arrayFuncionarios)
            {
                Console.WriteLine(func.getNome());
            }


            /*********************************
                Array de Tipos Anonimos
            /*********************************/

            var arrFuncionarios = new []
            {
                new{Nome="Jose",Sobrenome="Da Silva",Matricula=123},
                new{Nome="Maria",Sobrenome="Alves",Matricula=9721221}
            };

            var videogames = new []
            {
                new{Fabricante="Sony",Modelo="Playstation 5",Valor=499.99},
                new{Fabricante="Nintendo",Modelo="Switch",Valor=299.99},
                new{Fabricante="Microsoft",Modelo="XBOX Serie X",Valor=499.99}
            };

            




        }
    }
}
